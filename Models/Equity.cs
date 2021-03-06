﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuoteTool.Models
{
    [Table("equities")]
    public class Equity : BaseEntity
    {
        public Equity()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("symbol_name")]
        public string SymbolName { get; set; }

        [Column("symbol")]
        public string Symbol { get; set; }      
    }
}
