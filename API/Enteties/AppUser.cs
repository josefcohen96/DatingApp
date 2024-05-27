using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace API.Enteties;

public class AppUser
{
    public int Id { get; set; } // defailt primary key 
    public string UserName { get; set; }

}
