using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api_Cartao_Credito.Controllers.v1
{
    /// <summary>
    /// Recurso para gerenciamento de informações de cartão de crédito
    /// </summary>
    [Route("public/v1/api/[controller]")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        /// <summary>
        /// Obter a informação se a comrpa está validada
        /// </summary>
        /// <param name="idusuario">Id do usuário da compra</param>
        /// <param name="numerocartao">Número cartão crédito</param>
        /// <param name="valor">Valor da compra</param>
        /// <returns></returns>

        [HttpGet]
        public ActionResult<bool> Get(int idusuario, int numerocartao, double valor)
        {
            return Ok(true);
        }
    }
}
