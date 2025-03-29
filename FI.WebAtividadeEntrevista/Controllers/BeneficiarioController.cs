using System.Collections.Generic;
using System;
using System.Web.Mvc;
using FI.AtividadeEntrevista.BLL;
using FI.AtividadeEntrevista.DML;
using WebAtividadeEntrevista.Models;

namespace FI.WebAtividadeEntrevista.Controllers
{
    public class BeneficiarioController : Controller
    {

        [HttpGet]
        public ActionResult BeneficiarioList(long? idCliente)
        {
            BoBeneficiario bo = new BoBeneficiario();
            try
            {
                if (idCliente is null)
                    return PartialView("BeneficiariosModal",
                        new ListaBeneficiariosModel()
                        {
                            Beneficiarios = new List<BeneficiarioModel>()
                        });

                List<Beneficiario> beneficiarios = bo.ListarPorIdCliente(idCliente.Value);

                ListaBeneficiariosModel model = new ListaBeneficiariosModel();
                model.Beneficiarios = new List<BeneficiarioModel>();

                foreach (var beneficiario in beneficiarios)
                {
                    model.Beneficiarios.Add(new BeneficiarioModel
                    {
                        Id = beneficiario.Id,
                        CPF = beneficiario.CPF,
                        Nome = beneficiario.Nome,
                        IdCliente = beneficiario.IdCliente
                    });
                }

                return PartialView("BeneficiarioModal", model);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }
    }
}