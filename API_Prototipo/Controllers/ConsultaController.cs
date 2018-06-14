using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Prototipo.Models;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace API_Prototipo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        /// <summary>
        /// Recebe um número de 11 ou 14 dígitos e retorna informações
        /// necessárias para protótipo proposto.
        /// </summary>
        /// <param name="cpf_cnpj">CPF ou CNPJ</param>
        /// <returns>Objeto contendo valores para a prototipação proposta.
        /// </returns>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        // GET: api/Consulta/5
        [HttpGet("{id}", Name = "Get")]
        public JsonResult Get(string id)
        {
            Result Retorno = new Result();

            Regex regex1 = new Regex(@"\d{11}"); //11 Dígitos CPF (Sem validações)
            Regex regex2 = new Regex(@"\d{14}"); //14 Dígitos CNPJ(Sem validações)

            if (regex1.IsMatch(id) || regex2.IsMatch(id))
            {

                if (id == "12345678901")
                {
                    Retorno.ClienteLocalizado = true;
                    Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                    Retorno.MaisDeUmContratoAtivo = false;
                    Retorno.ClienteAdimplente = true;
                    Retorno.AgendaAtiva = false;
                    Retorno.ContratoElegivelParaMP = true;
                }
                else
                {
                    if (id == "12345678902")
                    {
                        Retorno.ClienteLocalizado = true;
                        Retorno.ExecutouManutencaoDeAgendaEmD0 = true;
                        Retorno.MaisDeUmContratoAtivo = false;
                        Retorno.ClienteAdimplente = true;
                        Retorno.AgendaAtiva = false;
                        Retorno.ContratoElegivelParaMP = true;
                    }
                    else
                    {
                        if (id == "12345678903")
                        {
                            Retorno.ClienteLocalizado = true;
                            Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                            Retorno.MaisDeUmContratoAtivo = true;
                            Retorno.ClienteAdimplente = true;
                            Retorno.AgendaAtiva = false;
                            Retorno.ContratoElegivelParaMP = true;
                        }
                        else
                        {
                            if (id == "12345678904")
                            {
                                Retorno.ClienteLocalizado = true;
                                Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                                Retorno.MaisDeUmContratoAtivo = false;
                                Retorno.ClienteAdimplente = false;
                                Retorno.AgendaAtiva = false;
                                Retorno.ContratoElegivelParaMP = true;
                            }
                            else
                            {
                                if (id == "12345678905")
                                {
                                    Retorno.ClienteLocalizado = true;
                                    Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                                    Retorno.MaisDeUmContratoAtivo = false;
                                    Retorno.ClienteAdimplente = true;
                                    Retorno.AgendaAtiva = true;
                                    Retorno.ContratoElegivelParaMP = true;
                                }
                                else
                                {
                                    if (id == "12345678906")
                                    {
                                        Retorno.ClienteLocalizado = true;
                                        Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                                        Retorno.MaisDeUmContratoAtivo = false;
                                        Retorno.ClienteAdimplente = true;
                                        Retorno.AgendaAtiva = false;
                                        Retorno.ContratoElegivelParaMP = false;
                                    }
                                    else
                                    {
                                        if (id == "12345678907")
                                        {
                                            Retorno.ClienteLocalizado = false;
                                            Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                                            Retorno.MaisDeUmContratoAtivo = false;
                                            Retorno.ClienteAdimplente = true;
                                            Retorno.AgendaAtiva = false;
                                            Retorno.ContratoElegivelParaMP = true;
                                        }
                                        else
                                        {
                                            Random randNum = new Random();
                                            int Rand_1 = randNum.Next(1, 10);
                                            int Rand_2 = randNum.Next(1, 10);
                                            int Rand_3 = randNum.Next(1, 10);
                                            int Rand_4 = randNum.Next(1, 10);
                                            int Rand_5 = randNum.Next(1, 10);
                                            int Rand_6 = randNum.Next(1, 10);

                                            if (Rand_1 < 8)
                                            {
                                                Retorno.ClienteLocalizado = false;
                                            }
                                            else
                                            {
                                                Retorno.ClienteLocalizado = true;
                                            }

                                            if (Rand_2 < 1)
                                            {
                                                Retorno.ExecutouManutencaoDeAgendaEmD0 = false;
                                            }
                                            else
                                            {
                                                Retorno.ExecutouManutencaoDeAgendaEmD0 = true;
                                            }

                                            if (Rand_3 < 1)
                                            {
                                                Retorno.MaisDeUmContratoAtivo = false;
                                            }
                                            else
                                            {
                                                Retorno.MaisDeUmContratoAtivo = true;
                                            }

                                            if (Rand_4 < 10)
                                            {
                                                Retorno.ClienteAdimplente = false;
                                            }
                                            else
                                            {
                                                Retorno.ClienteAdimplente = true;
                                            }

                                            if (Rand_5 < 8)
                                            {
                                                Retorno.AgendaAtiva = false;
                                            }
                                            else
                                            {
                                                Retorno.AgendaAtiva = true;
                                            }

                                            if (Rand_6 < 2)
                                            {
                                                Retorno.ContratoElegivelParaMP = false;
                                            }
                                            else
                                            {
                                                Retorno.ContratoElegivelParaMP = true;
                                            }


                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //string json = JavaScriptSerializer.Serialize(new { results = resultRows });
                var Json2 = JsonConvert.SerializeObject(Retorno);
                
                var Json = new JsonResult(Retorno);
                return Json;
                //return Json;
            }
            else
            {
                Retorno.Erro = "O formato é incorreto";
                var Json = new JsonResult(Retorno);
                return Json;
                
                
            }
        }
    }

        
}

