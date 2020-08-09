﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WordCounterBot.Common.Entities;

namespace WordCounterBot.DAL.Contracts
{
    public interface ICounterDatedDao
    {
        Task<List<CounterDated>> GetCounters(long chatId, DateTime date, int userLimit);

        Task<List<CounterDated>> GetCounters(long chatId, DateTime dateFrom, TimeSpan dateLimit, int userLimit);

        Task UpdateElseCreateCounter(long chatId, long userId, DateTime date, long counts);
    }
}