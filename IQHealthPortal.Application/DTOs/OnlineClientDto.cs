using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IQHealthPortal.Application.DTOs
{
    public class OnlineClientDto
    {
       
        public int ClientId { get; set; }

      
        public string ClientName { get; set; }

      


        public byte IsActive { get; set; }

    }
}
