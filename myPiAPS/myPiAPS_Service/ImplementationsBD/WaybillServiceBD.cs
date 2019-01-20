using Microsoft.Office.Interop.Word;
using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class WaybillServiceBD : IWaybillService
    {
        private PiAPSDbContext context;

        public WaybillServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        public List<WaybillBM> FindWaybill(int idWaybill)
        {
            List<WaybillBM> result = context.Waybills
                .Select(rec => new WaybillBM
                {
                    Id = rec.Id,
                    Date = rec.Date,
                    Customer = rec.Customer,
                    Summa = rec.Summa,
                    Koef = rec.Koef,
                    TypeOfWaybillId = rec.TypeOfWaybillId,
                    ShopHallId = rec.ShopHallId,
                    StockId = rec.StockId
                }).Where(recPG => recPG.Id == idWaybill)
                .ToList();
            return result;
        }

        public List<WaybillBM> GetList()
        {
            List<WaybillBM> result = context.Waybills
                            .Select(rec => new WaybillBM
                            {
                                Id = rec.Id,
                                Date = rec.Date,
                                Customer = rec.Customer,
                                Summa=rec.Summa,
                                Koef=rec.Koef,
                                TypeOfWaybillId=rec.TypeOfWaybillId,
                                ShopHallId=rec.ShopHallId,
                                StockId=rec.StockId
                            })
                            .ToList();
            return result;
        }

        public List<WaybillBM> GetListDeliv()
        {
            List<WaybillBM> result = context.Waybills
                  .Select(rec => new WaybillBM
                  {
                      Id = rec.Id,
                      Date=rec.Date,
                      Customer=rec.Customer,
                      Summa=rec.Summa,
                      Koef=rec.Koef,
                      TypeOfWaybillId=rec.TypeOfWaybillId,
                      ShopHallId=rec.ShopHallId,
                      StockId=rec.StockId
                  }).Where(rec=>rec.TypeOfWaybillId==3)
                  .ToList();
            return result;
        }

        public List<WaybillBM> GetListToday()
        {
            List<WaybillBM> list = context.Waybills
                  .Select(rec => new WaybillBM
                  {
                      Id = rec.Id,
                      Date = rec.Date,
                      Customer = rec.Customer,
                      Summa = rec.Summa,
                      Koef = rec.Koef,
                      TypeOfWaybillId = rec.TypeOfWaybillId,
                      ShopHallId = rec.ShopHallId,
                      StockId = rec.StockId
                  })
                  .ToList();
            List<WaybillBM> result = new List<WaybillBM>();
            foreach (WaybillBM r in list)
            {
                if (r.Date.Date == DateTime.Now.Date)
                {
                    result.Add(r);
                }
            }
            return result;
        }

        public bool PrintWaybill(string fileName,int idWaybill)
        {
            WaybillBM model= new WaybillBM();
            Waybill element = context.Waybills.FirstOrDefault(rec => rec.Id == idWaybill);
            if (element != null)
            {
                model= new WaybillBM
                {
                    Id = element.Id,
                    Date=element.Date,
                    Customer=element.Customer,
                    Summa=element.Summa,
                    Koef=element.Koef,
                    TypeOfWaybillId=element.TypeOfWaybillId,
                    ShopHallId=element.ShopHallId,
                    StockId=element.StockId
                };
            }

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                    winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                //задаем текстВ
                range.Text = "Ведомость доходов от предоставления займов";

                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();

                var paragraph12 = document.Paragraphs.Add(missing);
                var range12 = paragraph12.Range;
                //задаем текстВ
                range12.Text = "Печать от даты "+ (DateTime.Now.Date).ToString("yyyy.MM.dd");

                //задаем настройки шрифта
                var font12 = range12.Font;
                font12.Size = 16;
                font12.Name = "Times New Roman";
                font12.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat12 = range12.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range12.InsertParagraphAfter();


                string FromDate = (model.Date).ToString("yyyy.MM.dd");

                var paragraph2 = document.Paragraphs.Add(missing);
                var range2 = paragraph2.Range;
                //задаем текстВ
                range2.Text = "Дата: " + FromDate;
                //задаем настройки шрифта
                var font2 = range2.Font;
                font2.Size = 12;
                font2.Name = "Times New Roman";
                font2.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat2 = range2.ParagraphFormat;
                paragraphFormat2.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat2.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat2.SpaceAfter = 10;
                paragraphFormat2.SpaceBefore = 0;
                //добавляем абзац в документ
                range2.InsertParagraphAfter();

               

                var paragraph3 = document.Paragraphs.Add(missing);
                var range3 = paragraph3.Range;
                //задаем текстВ
                range3.Text = "Клиент: " + model.Customer;
                //задаем настройки шрифта
                var font3 = range3.Font;
                font3.Size = 12;
                font3.Name = "Times New Roman";
                font3.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat3 = range3.ParagraphFormat;
                paragraphFormat3.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat3.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat3.SpaceAfter = 10;
                paragraphFormat3.SpaceBefore = 0;
                //добавляем абзац в документ
                range3.InsertParagraphAfter();


                var paragraph4 = document.Paragraphs.Add(missing);
                var range4 = paragraph4.Range;
                //задаем текстВ
                range4.Text = "Коэффициент: " + model.Koef;
                //задаем настройки шрифта
                var font4 = range4.Font;
                font4.Size = 12;
                font4.Name = "Times New Roman";
                font4.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat4 = range4.ParagraphFormat;
                paragraphFormat4.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat4.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat4.SpaceAfter = 10;
                paragraphFormat4.SpaceBefore = 0;
                //добавляем абзац в документ
                range4.InsertParagraphAfter();

                var paragraph45 = document.Paragraphs.Add(missing);
                var range45 = paragraph45.Range;
                //задаем текстВ
                range45.Text = "Сумма: " + model.Summa;
                //задаем настройки шрифта
                var font45 = range45.Font;
                font45.Size = 12;
                font45.Name = "Times New Roman";
                font45.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat45 = range45.ParagraphFormat;
                paragraphFormat45.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat45.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat45.SpaceAfter = 10;
                paragraphFormat45.SpaceBefore = 0;
                //добавляем абзац в документ
                range45.InsertParagraphAfter();


                if (model.TypeOfWaybillId != null)
                {
                    var paragraph5 = document.Paragraphs.Add(missing);
                    var range5 = paragraph5.Range;
                    //задаем текстВ


                    range5.Text = "Тип: " + context.TypeOfWaybills.FirstOrDefault(rec => rec.Id == model.TypeOfWaybillId).Type;
                    //задаем настройки шрифта
                    var font5 = range5.Font;
                    font5.Size = 12;
                    font5.Name = "Times New Roman";
                    font5.Bold = 1;
                    //задаем настройки абзаца
                    var paragraphFormat5 = range5.ParagraphFormat;
                    paragraphFormat5.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    paragraphFormat5.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                    paragraphFormat5.SpaceAfter = 10;
                    paragraphFormat5.SpaceBefore = 0;
                    //добавляем абзац в документ
                    range5.InsertParagraphAfter();
                }

                if (model.ShopHallId != null)
                {
                    var paragraph6 = document.Paragraphs.Add(missing);
                    var range6 = paragraph6.Range;
                    //задаем текстВ
                    range6.Text = "Торговый зал: " + context.ShopHalls.FirstOrDefault(rec => rec.Id == model.ShopHallId).Name;
                    //задаем настройки шрифта
                    var font6 = range6.Font;
                    font6.Size = 12;
                    font6.Name = "Times New Roman";
                    font6.Bold = 1;
                    //задаем настройки абзаца
                    var paragraphFormat6 = range6.ParagraphFormat;
                    paragraphFormat6.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    paragraphFormat6.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                    paragraphFormat6.SpaceAfter = 10;
                    paragraphFormat6.SpaceBefore = 0;
                    //добавляем абзац в документ
                    range6.InsertParagraphAfter();
                }
                if (model.StockId!=null)
                {
                    var paragraph7 = document.Paragraphs.Add(missing);
                    var range7 = paragraph7.Range;
                    //задаем текстВ
                    range7.Text = "Склад: " + context.Stocks.FirstOrDefault(rec => rec.Id == model.StockId).Name;
                    //задаем настройки шрифта
                    var font7 = range7.Font;
                    font7.Size = 12;
                    font7.Name = "Times New Roman";
                    font7.Bold = 1;
                    //задаем настройки абзаца
                    var paragraphFormat7 = range7.ParagraphFormat;
                    paragraphFormat7.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    paragraphFormat7.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                    paragraphFormat7.SpaceAfter = 10;
                    paragraphFormat7.SpaceBefore = 0;
                    //добавляем абзац в документ
                    range7.InsertParagraphAfter();

                }
                //создаем таблицу

                List<ProductWaybillBM> result = context.ProductWaybills
                .Select(rec => new ProductWaybillBM
                {
                    Id = rec.Id,
                    ProductId=rec.ProductId,
                    WaybillId=rec.WaybillId,
                    Count=rec.Count
                }).Where(recPW=>recPW.WaybillId==idWaybill)
                .ToList();



                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, result.Count + 1, 3, ref missing, ref missing);

                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";

                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;


                table.Cell(1, 1).Range.Text = "Номер";
                table.Cell(1, 2).Range.Text = "Продукт";
                table.Cell(1, 3).Range.Text = "Кол-во";
               //table.Cell(1, 4).Range.Text = "Сумма";

                for (int i = 0; i < result.Count; ++i)
                {
                    /*  for (int j = 0; j < DATA.Columns.Count; ++j)
                      {
                          string s = DATA.Rows[i].ItemArray[j].ToString();
                          table.Cell(i + 2, j + 1).Range.Text = DATA.Rows[i].ItemArray[j].ToString();
                      }*/
                    int prId = result[i].ProductId;
                    Product prod = context.Products.FirstOrDefault(rec => rec.Id == prId);

                    table.Cell(i + 2, 1).Range.Text = (result[i].Id).ToString();
                    table.Cell(i + 2, 2).Range.Text = prod.Name;
                    table.Cell(i + 2, 3).Range.Text = (result[i].Count).ToString();
                }
                //задаем границы таблицы
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;

                range.Text = "Итого: " + model.Summa;



                font = range.Font;
                font.Size = 12;
                font.Name = "Times New Roman";

                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 10;

                range.InsertParagraphAfter();
                //сохраняем
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(fileName, ref fileFormat, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing);
                document.Close(ref missing, ref missing, ref missing);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
                
            }
            finally
            {
                winword.Quit();
            }
        }

        public List<WaybillBM> Sort(int idType)
        {
            List<WaybillBM> result = context.Waybills
                 .Select(rec => new WaybillBM
                 {
                     Id = rec.Id,
                     Date = rec.Date,
                     Customer = rec.Customer,
                     Summa = rec.Summa,
                     Koef = rec.Koef,
                     TypeOfWaybillId = rec.TypeOfWaybillId,
                     ShopHallId = rec.ShopHallId,
                     StockId = rec.StockId
                 }).Where(recPG => recPG.TypeOfWaybillId == idType)
                 .ToList();
            return result;
        }

        public double SumDeliv(int idDeliv)
        {
            throw new NotImplementedException();
        }

        public double SumToday()
        {
            double res = 0;
            List<WaybillBM> list = context.Waybills
                   .Select(rec => new WaybillBM
                   {
                       Id = rec.Id,
                       Date = rec.Date,
                       Customer = rec.Customer,
                       Summa = rec.Summa,
                       Koef = rec.Koef,
                       TypeOfWaybillId = rec.TypeOfWaybillId,
                       ShopHallId = rec.ShopHallId,
                       StockId = rec.StockId
                   }).Where(rec=> rec.TypeOfWaybillId!=5)
                   .ToList();
            List<WaybillBM> result = new List<WaybillBM>();
            foreach (WaybillBM r in list)
            {
                if (r.Date.Date == DateTime.Now.Date)
                {
                    result.Add(r);
                }
            }
            foreach (WaybillBM wb in result)
            {
                    res += wb.Summa;
            }


            return res;
        }
    }
}
