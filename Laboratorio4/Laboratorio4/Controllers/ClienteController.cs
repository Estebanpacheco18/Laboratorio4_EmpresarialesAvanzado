namespace Laboratorio4.Controllers;

using DTOs;
using Models;

using Microsoft.AspNetCore.Mvc;
using Data.Repositories.Interfaces;

using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public ClienteController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpPost]
    public IActionResult CrearCliente([FromBody] ClienteDto clienteDto)
    {
        var cliente = new clientes
        {
            ClienteID = clienteDto.ClienteID,
            Nombre = clienteDto.Nombre,
            Correo = clienteDto.Correo,
            FechaCreacion = clienteDto.FechaCreacion
        };
        _unitOfWork.Clientes.Add(cliente);
        _unitOfWork.SaveChanges();
        return Ok("Cliente creado con éxito");
    }

    [HttpGet]
    public IActionResult ObtenerClientes()
    {
        var clientes = _unitOfWork.Clientes.GetAll()
            .Select(c => new ClienteDto
            {
                ClienteID = c.ClienteID,
                Nombre = c.Nombre,
                Correo = c.Correo,
                FechaCreacion = c.FechaCreacion
            }).ToList();
        return Ok(clientes);
    }

    [HttpPut("{id}")]
    public IActionResult ActualizarCliente(int id, [FromBody] ClienteDto clienteDto)
    {
        var cliente = _unitOfWork.Clientes.GetById(id);
        if (cliente == null) return NotFound();

        cliente.Nombre = clienteDto.Nombre;
        cliente.Correo = clienteDto.Correo;
        cliente.FechaCreacion = clienteDto.FechaCreacion;

        _unitOfWork.Clientes.Update(cliente);
        _unitOfWork.SaveChanges();
        return Ok("Cliente actualizado con éxito");
    }

    [HttpDelete("{id}")]
    public IActionResult EliminarCliente(int id)
    {
        var cliente = _unitOfWork.Clientes.GetById(id);
        if (cliente == null) return NotFound();

        _unitOfWork.Clientes.Delete(cliente);
        _unitOfWork.SaveChanges();
        return Ok("Cliente eliminado con éxito");
    }
}


