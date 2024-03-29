using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciandoTarefas.Entities;
using Microsoft.EntityFrameworkCore;

namespace GerenciandoTarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext>options) : base(options){}
        public DbSet<Tarefa>Tarefa{get; set;}
    }
}