using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]
       {
            new Evento(){
                EventoId = 1,
                Tema = ".Net 6 e Angular 11",
                Local = "Fortaleza",
                Lote = "1 lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL= "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "ReactJS e suas novidades",
                Local = "Russas",
                Lote = "1 lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyy"),
                ImagemURL= "foto2.png"
            },         
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
       return _evento.Where(evento => evento.EventoId == id );
    }

    [HttpPost]
    public string Post()
    {
       return "Exemplo de POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exemplo de Put com id = {id}";
    }

    
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exemplo de Delete com id = {id}";
    }
}
