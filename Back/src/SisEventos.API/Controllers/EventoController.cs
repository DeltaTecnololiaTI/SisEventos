using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SisEventos.API.Model;

namespace SisEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        IEnumerable<Evento> _evento =  new Evento[]{
                new Evento(){
                    EventoId = 1
                    , Local = "Belo Horizonte"
                    , DataEvento = DateTime.Now.AddDays(2).ToString()
                    , Tema = "Angular 11 e .Net 5"
                    , QtdPessoas = 250
                    , Lote = "1º Lote"
                    , ImagemURL = "foto1.png"
                },
                new Evento(){
                    EventoId = 2
                    , Local = "São Paulo"
                    , DataEvento = DateTime.Now.AddDays(2).ToString()
                    , Tema = "Java 11 e JPA"
                    , QtdPessoas = 100
                    , Lote = "5º Lote"
                    , ImagemURL = "foto2.png"
                }           
            };
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento; 
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);          

        }
        [HttpPost]
        public string Post()
        {
            return "Value test Criar";

        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Value test id Atualiza = {id}";

        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Value test Delete id = {id}";

        }

    }
}