using AutoMapper;
using Azure.Core;
using IQHealthPortal.Application.ApprovalService.Queries.GetApproval;
using IQHealthPortal.Application.Interfaces.Repositories;
using MediatR;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMS_ONLINE_APPLICATION.ApprovalService.Queries.GetApproval
{
    public class GetApprovalDetailsHandler :IRequestHandler<GetApprovalQuery,GetApprovalDetailsQuery>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetApprovalDetailsHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<GetApprovalDetailsQuery> Handle(GetApprovalQuery request, CancellationToken cancellationToken)
        {
            if (request == null)
            {

            }

            //var tt = await _unitOfWork.ApprovalRepository.GetByIdAsync(request.ApprovalId);
            var approval =await ADO(request.ApprovalId);

            return _mapper.Map<GetApprovalDetailsQuery>(approval);
        }


        private async Task<GetApprovalDetailsQuery> ADO(long approvalId)
        {
            string connectionString = "data source=150.200.12.7;initial catalog=acms_migration;persist security info=True;user id=acms_login;password=acms@bms;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM approvals WHERE approval_id = @ApprovalId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApprovalId", approvalId);

                conn.Open();

                SqlDataReader reader = await cmd.ExecuteReaderAsync();

                GetApprovalDetailsQuery approval = null;

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        approval = new GetApprovalDetailsQuery
                        {
                            ApprovalId = reader.GetInt32(reader.GetOrdinal("approval_id")),
                            ApStatus = reader.GetString(reader.GetOrdinal("ApStatus")),
                            ApprovalDate = reader.GetDateTime(reader.GetOrdinal("ApprovalDate")),

                        };
                    }
                }

                reader.Close();
                return approval;
            }
        }
    }
}
