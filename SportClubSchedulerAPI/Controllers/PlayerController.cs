﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportClubSchedulerAPI.Models;

namespace SportClubSchedulerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private static List<Player> players = new()
        {
            new Player() { Id = 1, Name = "Fred", Height = 190 },
            new Player() { Id = 2, Name = "George", Height = 173 },
            new Player() { Id = 3, Name = "Alina", Height = 176 },
            new Player() { Id = 4, Name = "Tom", Height = 205 },
            new Player() { Id = 5, Name = "Sarah", Height = 161 }
        };
        private readonly DataContext dataContext;

        public PlayerController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> Get()
        {
            return Ok(await dataContext.Players.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> Get(int id)
        {
            var player = await dataContext.Players.FindAsync(id);
            if (player == null)
                return BadRequest("Player not fouind");
            return Ok(player);
        }

        [HttpPost]
        public async Task<ActionResult<List<Player>>> AddPlayer(Player player)
        {
            dataContext.Players.Add(player);
            await dataContext.SaveChangesAsync();

            return Ok(await dataContext.Players.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<Player>> UpdatePlayer(Player requestPlayer)
        {
            var dbPlayer = await dataContext.Players.FindAsync(requestPlayer.Id);
            if (dbPlayer == null)
                return BadRequest("Player not fouind");

            dbPlayer.Name = requestPlayer.Name;
            dbPlayer.Height = requestPlayer.Height;

            await dataContext.SaveChangesAsync();

            return Ok(await dataContext.Players.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Player>>> DeletePlayer(int id)
        {
            var player = await dataContext.Players.FindAsync(id);
            if (player == null)
                return BadRequest("Player not fouind");

            dataContext.Players.Remove(player);
            await dataContext.SaveChangesAsync();

            return Ok(await dataContext.Players.ToListAsync());
        }
    }
}