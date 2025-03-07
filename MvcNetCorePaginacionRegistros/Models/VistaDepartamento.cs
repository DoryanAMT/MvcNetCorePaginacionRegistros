using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Threading;

namespace MvcNetCorePaginacionRegistros.Models
{
    #region
    //create or alter view V_DEPARTAMENTOS_INDIVIDUAL
    //as
	   // select ROW_NUMBER() over(order by DEPT_NO) as POSICION
	   // , DEPT_NO, DNOMBRE, LOC from DEPT
    //go
    #endregion
    [Table("V_DEPARTAMENTOS_INDIVIDUAL")]
    public class VistaDepartamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int IdDepartamento { get; set; }
        [Column("DNOMBRE")]
        public string Nombre { get; set; }
        [Column("LOC")]
        public string Localidad { get; set; }
        [Column("POSICION")]
        public int Posicion { get; set; }
    }
}
