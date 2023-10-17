﻿using Fiap.Api.Donation1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Api.Donation1.Models
{
    [Table("Produto")] // Notação para indicar que classe representa tabela do banco
    [Index(nameof(DataCadastro), IsUnique = false)]
    public class ProdutoModel
    {
        [Key] // Para indicar chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Notação para gerar Id automático e incremental
        public int ProdutoId { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public bool Disponivel { get; set; }

        // Foreign Key
        public int TipoProdutoId { get; set; }

        // Navigation Property
        // [ForeignKey("TipoProdutoId")]
        [ForeignKey(nameof(TipoProdutoId))] // Jeito mais assertivo
        public TipoProdutoModel TipoProduto { get; set; }

        [StringLength(150)]
        public string Descricao { get; set; }

        [StringLength(200)]
        public string SugestaoTroca { get; set; }

        public double Valor { get; set; }

        // [DefaultValue(typeof(DateTime), DateTime.)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public DateTime DataExpiracao { get; set; }

        // Navigation Property
        [ForeignKey(nameof(UsuarioId))]
        public UsuarioModel Usuario { get; set; }

        // Foreign Key
        public int UsuarioId { get; set; }


        public ProdutoModel()
        {

        }

        public ProdutoModel(int produtoId, string nome, bool disponivel, string descricao, string sugestaoTroca, double valor, int usuarioId, int tipoProdutoId)
        {
            ProdutoId = produtoId;
            Nome = nome;
            Disponivel = disponivel;
            Descricao = descricao;
            SugestaoTroca = sugestaoTroca;
            Valor = valor;
            UsuarioId = usuarioId;
            TipoProdutoId = tipoProdutoId;
            DataCadastro = DateTime.Now;
            DataExpiracao = DateTime.Now.AddMonths(18);
        }
    }
}
