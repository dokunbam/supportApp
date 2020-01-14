using Microsoft.AspNetCore.Mvc;
using FCMB_Support_App.Data;
using FCMB_Support_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using FCMB_Support_App.Helpers;

namespace FCMB_Support_App.Services
{
    public class ClientServices
    {
        private readonly ApplicationDbContext applicationDbContext;
        public IList<Client> SearchList { get; set; }


        public ClientServices(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
              
        }

        //internal async Task<List<Client>> GetClientsList([FromQuery]PaginationDTO pagination)
        //{
        //    var queryable = applicationDbContext.Clients.AsQueryable();
        //    await HttpContext.InsertPaginationParameterInResponse(queryable, pagination.QuantityPerPage);
        //    return await queryable.Paginate(pagination).ToListAsync();
          
        //}

        public async Task<Client> GetOneClient(int Id) 
        {
            var client = await applicationDbContext.Clients.FirstOrDefaultAsync(c => c.ClientId == Id);

            return client;
        }

        public async Task<Client> CreateClients(Client client)
        {

            applicationDbContext.Clients.Add(client);
            await applicationDbContext.SaveChangesAsync();

            return client;

        }

        public async Task<Client> EditClient(int Id, Client clients)
        {
            await applicationDbContext.Clients.FindAsync(Id);

            applicationDbContext.Entry(clients).State = EntityState.Modified;

            try
            {
                await applicationDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(Id))
                {
                    return NoContent();
                }
                else
                {
                    throw;
                }
            }


            return NoContent();
        }

        public async Task<Client> RemoveClient(int id) 
        {
            var client = await applicationDbContext.Clients.FindAsync(id);

            applicationDbContext.Clients.Remove(client);
            await applicationDbContext.SaveChangesAsync();

            return client;
        }



        //internal async Task SearchQueries(string searchString)
        //{
        //    var search = from s in applicationDbContext.Clients select s;

        //    if (string.IsNullOrEmpty(searchString))
        //    {
        //        search = search.Where(s => s.Name.Contains(searchString) || s.Phone.Contains(searchString));
        //    }

        //    SearchList = await search.ToListAsync();
        //    //return await applicationDbContext.Clients.ToListAsync();
        //}

        internal async Task SearchQueries(Client searchString)
        {
            var search = from s in applicationDbContext.Clients select s;

            if (searchString != null)
            {
                search = search.Where(s => s.Name.Contains(searchString.Name) || s.Phone.Contains(searchString.Phone));
            }

            SearchList = await search.ToListAsync();
            //return await applicationDbContext.Clients.ToListAsync();
        }


        private Client NoContent()
        {
            throw new NotImplementedException();
        }

        private bool ClientExists(int id)
        {
            return applicationDbContext.Clients.Any(e => e.ClientId == id);
        }
    }
}
