﻿using Banking_Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Banking_Api.Data
{
    public class BankingDbContext:IdentityDbContext<User>
    {

        public BankingDbContext(DbContextOptions<BankingDbContext> options)
            : base(options)
        {
        }



    }


}
