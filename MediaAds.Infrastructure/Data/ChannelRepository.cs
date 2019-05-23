﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediaAds.Core.Interfaces;
using MediaAds.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaAds.Infrastructure.Data
{
    public class ChannelRepository : BaseRepository<Channel>, IChannelRepository
    {
        private readonly MediaDbContext _db;

        public ChannelRepository(MediaDbContext context) : base(context)
        {
            _db = context;
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _db.Categories.ToListAsync();
        }

        //public async Task<List<Channel>> GetByCategory(int categoryId)
        //{
        //TODO: add logic
        //}
    }
}
