﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Data
{
    public partial class movimentacao : classe_base
    {
        public movimentacao()
        {
            this.data_saida = DateTime.Today;
        }
        [Key]
        public int movimentacao_id { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Campo Data de Saída é obrigatório")]
        [Display(Name = "Data de Saída")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime data_saida { get; set; }
        [Display(Name = "Data de Retorno")]
        public DateTime? data_retorno { get; set; }
        public int funcionario_id { get; set; }
        [Required(ErrorMessage = "Campo Funcionário é obrigatório")]
        [Display(Name = "Funcionário")]
        public funcionario funcionario { get; set; }
        [Required(ErrorMessage = "Campo Tipo de Movimentação é obrigatório")]
        [Display(Name = "Tipo de Movimentação")]
        public string tipo_movimentacao { get; set; }
    }
}