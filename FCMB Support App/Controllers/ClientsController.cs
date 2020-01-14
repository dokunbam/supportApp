using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FCMB_Support_App.Data;
using FCMB_Support_App.Models;
using FCMB_Support_App.Services;
using Microsoft.AspNetCore.Authorization;
using FCMB_Support_App.Helpers;

namespace FCMB_Support_App.Controllers
{
    [Route("/fcmb")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ClientServices clientServices;


        //Constructor
        public ClientsController(ApplicationDbContext context, ClientServices _clientServices)
        {
            _context = context;
            clientServices = _clientServices;
        }


        //Get all clients
        //[Authorize]
        [HttpGet]
        [Route("clients")]
        public async Task<List<Client>> GetAllClients([FromQuery]PaginationDTO pagination, [FromQuery] string name)
        {
            var queryable = _context.Clients.AsQueryable();

            if (!string.IsNullOrEmpty(name)) 
            {
                queryable = queryable.Where(x => x.Name.Contains(name));
            }
            await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
            return await queryable.Paginate(pagination).ToListAsync();
        }

        [Authorize]
        [HttpGet]
        [Route("getclient")]
        public async Task<ActionResult<Client>> OneClient(int Id)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.ClientId == Id);

            if (client == null)
            {
                return NotFound();
            }

            var current = await clientServices.GetOneClient(Id);

            return current;
        }

        //Post client
        [Authorize]
        [HttpPost]
        [Route("newclient")]
        public async Task<ActionResult<Client>>PostClients (Client client)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest();
            }

            await clientServices.CreateClients(client);
            return Ok(client);
        }


        // POST: api/Clients/5
        [Authorize]
        [HttpPut]
        [Route("putclient")]
        public async Task<ActionResult<Client>> PutClient(int id, Client client)
        {
            var clients = await _context.Clients.FindAsync(client);

            if (clients == null)
            {
                return NotFound();
            }

            var current = await clientServices.EditClient(id, client);

            return current;
        }


        [Authorize]
        [HttpDelete]
        [Route("removeclient")]
        public async Task<ActionResult<Client>> DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            
            if (client == null)
            {
                return NotFound();
            }

            await clientServices.RemoveClient(id);

            return client;
        }
        [Authorize]
        [HttpGet]
        [Route("search")]
        public async Task<Client> Search(Client client)
        {
            //var searcResult = applicationDbContext.Clients.Find(search);
            await clientServices.SearchQueries(client);
            return client;
        }
    }
}
