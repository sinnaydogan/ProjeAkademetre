using ClosedXML.Excel;
using ProjeAkademetre.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeAkademetre.Controllers
{
    public class ExcelController : Controller
    {
        kisiModel kisiModel1 = new kisiModel();

        public ExcelController()
        {
            kisiModel1.kisiModelName = "";
            kisiModel1.kisiModelSurname = "";
            kisiModel1.kisiModelAdres = "";
            kisiModel1.kisiModelMail = "";
            /*for (int i = 1; i <= 1; i++)
            {
                _okisiModels.Add(new kisiModel()
                {
                    kisiModelName = "",
                    kisiModelSurname = "",
                    kisiModelAdres = "",
                    kisiModelMail = ""

                });
            }*/
        }
        [HttpPost]
        public ActionResult Another(string firstName, string surName, string adres, string mail)
        {

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Kişiler");
                var currentRow = 1;
                #region Header
                worksheet.Cell(currentRow, 1).Value = "İsim";
                worksheet.Cell(currentRow, 2).Value = "Soyisim";
                worksheet.Cell(currentRow, 3).Value = "Adres";
                worksheet.Cell(currentRow, 4).Value = "Mail";
                #endregion
                #region Body

                currentRow++;
                worksheet.Cell(currentRow, 1).Value = firstName;
                worksheet.Cell(currentRow, 2).Value = surName;
                worksheet.Cell(currentRow, 3).Value = adres;
                worksheet.Cell(currentRow, 4).Value = mail;



                #endregion

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(
                              content,
                              "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                              "Kişiler.xlsx"
                              );
                }


            }
        }

    }
}