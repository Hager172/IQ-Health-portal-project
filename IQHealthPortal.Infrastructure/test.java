/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.javatmp.web.controller.user;

import com.javatmp.domain.User;
import com.javatmp.mvc.MvcHelper;
import com.javatmp.mvc.domain.ResponseMessage;
import com.sa.db.Imssqdb;
import com.sa.db.mssqdb;
import com.sa.db.mssqldb;
import java.io.IOException;
import java.text.DecimalFormat;
import javax.servlet.ServletException;
import javax.servlet.annotation.MultipartConfig;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author DB1
 */
@WebServlet("/user/UpdateClaimController")
@MultipartConfig(fileSizeThreshold = 1024 * 15, maxFileSize = 1024 * 50, maxRequestSize = 1024 * 200)
public class UpdateClaimController extends HttpServlet {

    private static final long serialVersionUID = 1L;
//    mssqdb mydb = new mssqdb();

    @Override
    protected void doGet(HttpServletRequest request,
            HttpServletResponse response) throws ServletException, IOException {
        ResponseMessage responseMessage = new ResponseMessage();
        HttpSession session = request.getSession();
        User b = (User) session.getAttribute("user");
        
        Imssqdb mydb = b.getClient().equals("1") ? new mssqdb():new mssqldb();
        
        int role = b.getRoleId();
        String a = request.getParameterValues("days")[0];

        String[] days = a.split(",");
        a = request.getParameterValues("approved")[0];
        String[] approved = a.split(",");

        String notes = request.getParameter("notes");
        String id = request.getParameter("id");
        a = request.getParameterValues("disc")[0];
        String[] disc = a.split(",");
        a = request.getParameterValues("itemid")[0].replace("]", "").replace("[", "");
        String[] itemsId = a.split(",");
        a = request.getParameterValues("claim")[0];
        String[] claimed = a.split(",");
        boolean state = false;
        for (int i = 0; i < claimed.length; i++) {
            if (approved[i] == "NaN") {
                approved[i] = "0";
            }
            if (Integer.parseInt(approved[i]) > Integer.parseInt(claimed[i])) {
                state = false;
                break;
            } else {
                state = true;
            }

        }
        User currentUser = (User) session.getAttribute("user");
        if (state && (role == 1 || role == 4)) {
            int acode = mydb.UpdateClaims(days, approved, disc, id, notes, itemsId, currentUser, false);
            if (acode > 100) {
                responseMessage.setData("1");
                new Thread(() -> {
                    mydb.sendToLocal(id, 2);
                }).start();
                new Thread(() -> {
                    mydb.sendToLocal("10" + acode, 1);
                }).start();
            } else {
                responseMessage.setData("0");
                  new Thread(() -> {
                    mydb.sendToLocal(id, 2);
                }).start();
            }

        }
        else {
            responseMessage.setData("-1");

        }

        responseMessage.setOverAllStatus(true);
        MvcHelper.sendMessageAsJson(response, responseMessage);

    }
}


public int UpdateClaims(String[] days, String[] approv, String[] disc, String id, String notes, String[] itemsId, User user, boolean isChronic) {

        try (Connection connection = DriverManager.getConnection(connectionUrl);) {
            ResultSet rs = null;
            Statement statement = connection.createStatement();
            String query = "";
            String status = "";
            if (isChronic) {
                for (int i = 0; i < approv.length; i++) {

                    query += "update approval_services set qty =" + approv[i] + ",days='" + days[i] + "',item_desc='" + disc[i] + "', med_item = case when med_item =-1 then 1 else med_item end where approval_id =" + id + " and item_serial = " + itemsId[i] + ";"
                            + "update approval_services_online set qty =" + approv[i] + ",days='" + days[i] + "',item_desc='" + disc[i] + "', med_item = case when med_item =-1 then 1 else med_item end where approval_id =" + id + " and item_serial = " + itemsId[i] + ";";

                }

                query += "update approvals  set online_b_code = '" + user.getOffice().trim() + "',vendor_id = '" + user.getVendor().trim() + "', online_status = 'P',ap_status ='D',NOTES = '" + notes + "',online_lud = getdate(), online_user ='" + user.getUserName() + "' where approval_id =" + id + " and online_status = 'N';"
                        + "update approvals_online  set online_b_code = '" + user.getOffice().trim() + "',vendor_id = '" + user.getVendor().trim() + "', online_status = 'P',ap_status ='D',NOTES = '" + notes + "',online_lud = getdate(), online_user ='" + user.getUserName() + "' where approval_id =" + id + " and online_status = 'N'";

                statement.execute(query);
                String year = Integer.toString(Year.now().getValue()).substring(2);

                CallableStatement cstatement = connection
                        .prepareCall("{? = call dbo.generate_remaining_items(?,?)}");
                cstatement.setString(2, id);
                cstatement.setString(3, year);
                cstatement.registerOutParameter(1, java.sql.Types.INTEGER);
                cstatement.executeUpdate();
                return cstatement.getInt(1);

            } else {
                for (int i = 0; i < approv.length; i++) {

                    query += "update approval_services set qty =" + approv[i] + ",days='" + days[i] + "',item_desc='" + disc[i] + "',online_status = " + (approv[i] == "0" ? "online_status" : "'a'") + " where approval_id =" + id + " and item_serial = " + itemsId[i] + ";"
                            + "update approval_services_online set qty =" + approv[i] + ",days='" + days[i] + "',item_desc='" + disc[i] + "',online_status = " + (approv[i] == "0" ? "online_status" : "'a'") + " where approval_id =" + id + " and item_serial = " + itemsId[i] + ";";

                }
                query += "update approvals  set isNotified=0, online_status = 'P',ap_status ='D',NOTES = '" + notes + "',Last_update_date = getdate(), Last_update_by ='" + user.getUserName() + "' where approval_id =" + id + " and online_status = 'N'; update approval_services set MED_ITEM = 1 where approval_id = " + id + " and MED_ITEM = -1; "
                        + "update approvals_online  set isNotified=0, online_status = 'P',ap_status ='D',NOTES = '" + notes + "',Last_update_date = getdate(), Last_update_by ='" + user.getUserName() + "' where approval_id =" + id + " and online_status = 'N'; update approval_services set MED_ITEM = 1 where approval_id = " + id + " and MED_ITEM = -1;";
                statement.execute(query);

            }
        } catch (Exception ex) {
            String x = ex.getMessage();

        }

        return 0;
    }

    public void sendToLocal(String approvalCode, int type) {
        ResultSet resultSet = null;
        try (Connection connection = DriverManager.getConnection(remoteConnectionUrl);) {
            CallableStatement cstatement = connection
                    .prepareCall("{? = call dbo.sp_manual_approvals_repl(?,?)}");
            cstatement.setString(2, approvalCode);
            cstatement.setInt(3, type);
            cstatement.registerOutParameter(1, java.sql.Types.INTEGER);
//            PreparedStatement ps = connection.prepareStatement(queryString);
            cstatement.executeUpdate();
        } // Handle any errors that may have occurred.
        catch (SQLException e) {

            try (Connection connection = DriverManager.getConnection(connectionUrl);) {
                Statement statement = connection.createStatement();
                resultSet = statement.executeQuery("insert into online_repl_errors values(" + approvalCode + ",getdate(),'" + e.getMessage() + "'," + type + ",0)");

            } // Handle any errors that may have occurred.
            catch (SQLException ee) {

            }
        }
        //  return resultSet;
    }

    public void sendTSMS(String phone, String msg) {
        try {
            HttpURLConnection conn = null;//Declare the connection to sms api url
            URIBuilder b = new URIBuilder(smsUrl);
            b.addParameter("phone", phone);
            b.addParameter("msg", msg);
            b.addParameter("key", "dEm0K");

            URL url = b.build().toURL();
            conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Accept", "application/json");
            //conn.setRequestProperty("apikey",apiKey);}
            int res_code = conn.getResponseCode();
        } catch (Exception e) {
        }
    }