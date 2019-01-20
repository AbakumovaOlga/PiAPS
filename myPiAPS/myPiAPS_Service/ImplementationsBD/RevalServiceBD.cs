using myPiAPS_Model;
using myPiAPS_Service.BindingModels;
using myPiAPS_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPiAPS_Service.ImplementationsBD
{
    public class RevalServiceBD : IRevalService
    {
        private PiAPSDbContext context;
        public int haves = 0;

        public RevalServiceBD(PiAPSDbContext context)
        {
            this.context = context;
        }

        /*public double Calc(WaybillBM model)
        {
            int haves = 0;
          List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId
            }).Where(rec => rec. == model.StockId & rec.Id != model.Id).ToList();

            foreach (var ProductWaybill in model.ProductWaybills)
            {
                int needs = ProductWaybill.Count;
                int haves = 0;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3 || wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }
                }
            }
            return haves ;
        }*/


        public double CalcSum(WaybillBM model, double nPrice)
        {

            //для каждого продукта получить список чеков, где он указывается
            //получить тип
            //разделить на список прихода и расхода
            // пройтись с соединенем продукт-чек
            //получить кол-во
            List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId
            }).Where(rec => rec.Id != model.Id).ToList();

            double SumProdictsOld = 0;
            double SumProdictsNew = 0;

            foreach (var ProductWaybill in model.ProductWaybills)
            {
                Product prod = context.Products.FirstOrDefault(rec => rec.Id == ProductWaybill.ProductId);
                double price = prod.Price;
                haves = 0;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3 || wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }
                }

                double sumProduct = haves * price;
                SumProdictsOld += sumProduct;
                double sumProductNew = haves * nPrice;
                SumProdictsNew += sumProductNew;
            }
            return SumProdictsNew - SumProdictsOld;
        }

        public double CalcSumGroup(WaybillBM model, double koeff)
        {
            List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId
            }).Where(rec => rec.Id != model.Id).ToList();

            double SumProdictsOld = 0;
            double SumProdictsNew = 0;

            foreach (var ProductWaybill in model.ProductWaybills)
            {
                Product prod = context.Products.FirstOrDefault(rec => rec.Id == ProductWaybill.ProductId);
                double price = prod.Price;
                int haves = 0;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3 || wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == ProductWaybill.ProductId)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }
                }

                double sumProduct = haves * price;
                SumProdictsOld += sumProduct;
                double sumProductNew = haves * price*koeff;
                SumProdictsNew += sumProductNew;
            }
            return SumProdictsNew - SumProdictsOld;
        }

        public void CreateReval(WaybillBM model, double nPrice)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Waybill element = new Waybill
                    {
                        Date = model.Date,
                        TypeOfWaybillId = Convert.ToInt32(5 + ""),

                        Summa = CalcSum(model, nPrice)

                    };
                    context.Waybills.Add(element);
                    context.SaveChanges();
                    // убираем дубли по компонентам
                    /* var groupProducts = model.ProductWaybills
                                                 .GroupBy(rec => rec.ProductId)
                                                 .Select(rec => new
                                                 {
                                                     ProductId = rec.Key,
                                                     Count = rec.Sum(r => r.Count)
                                                 });
                     // добавляем компоненты
                     foreach (var groupProduct in groupProducts)
                     {
                         context.ProductWaybills.Add(new ProductWaybill
                         {
                             WaybillId = element.Id,
                             ProductId = groupProduct.ProductId,
                             Count = groupProduct.Count
                         });
                         context.SaveChanges();
                     }*/
                    foreach (var ProductWaybill in model.ProductWaybills)
                    {
                        ProductWaybill productWaybill = new ProductWaybill
                        {
                            WaybillId = element.Id,
                            ProductId = ProductWaybill.ProductId,
                            Count = ProductWaybill.Count
                        };
                        context.ProductWaybills.Add(productWaybill);
                        context.SaveChanges();

                    }

                    int id = model.ProductWaybills[0].ProductId;

                    /*Product productUpd = context.Products.FirstOrDefault(rec => rec.Id == id);
                    if (productUpd == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    //   Product p = new Product { Price = nPrice };

                    productUpd.Price = nPrice;
                    productUpd.Producer = "fgfj";
                    context.SaveChanges();*/


                    foreach (ProductWaybillBM pw in model.ProductWaybills)
                    {
                        Product productUpd = context.Products.FirstOrDefault(rec => rec.Id == pw.ProductId);
                        if (productUpd == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        //   Product p = new Product { Price = nPrice };

                        productUpd.Price = nPrice;
                        context.SaveChanges();
                    }
                    // context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void CreateRevalGroup(WaybillBM model, double koeff)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Waybill element = new Waybill
                    {
                        Date = model.Date,
                        TypeOfWaybillId = Convert.ToInt32(5 + ""),
                        Koef=model.Koef,
                        Summa = CalcSumGroup(model, koeff)

                    };
                    context.Waybills.Add(element);
                    context.SaveChanges();
                    // убираем дубли по компонентам
                    /* var groupProducts = model.ProductWaybills
                                                 .GroupBy(rec => rec.ProductId)
                                                 .Select(rec => new
                                                 {
                                                     ProductId = rec.Key,
                                                     Count = rec.Sum(r => r.Count)
                                                 });
                     // добавляем компоненты
                     foreach (var groupProduct in groupProducts)
                     {
                         context.ProductWaybills.Add(new ProductWaybill
                         {
                             WaybillId = element.Id,
                             ProductId = groupProduct.ProductId,
                             Count = groupProduct.Count
                         });
                         context.SaveChanges();
                     }*/
                    foreach (var ProductWaybill in model.ProductWaybills)
                    {
                        ProductWaybill productWaybill = new ProductWaybill
                        {
                            WaybillId = element.Id,
                            ProductId = ProductWaybill.ProductId,
                            Count = ProductWaybill.Count
                        };
                        context.ProductWaybills.Add(productWaybill);
                        context.SaveChanges();

                    }

                    int id = model.ProductWaybills[0].ProductId;

                    /*Product productUpd = context.Products.FirstOrDefault(rec => rec.Id == id);
                    if (productUpd == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    //   Product p = new Product { Price = nPrice };

                    productUpd.Price = nPrice;
                    productUpd.Producer = "fgfj";
                    context.SaveChanges();*/


                    foreach (ProductWaybillBM pw in model.ProductWaybills)
                    {
                        Product productUpd = context.Products.FirstOrDefault(rec => rec.Id == pw.ProductId);
                        if (productUpd == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        //   Product p = new Product { Price = nPrice };

                        double old = productUpd.Price;
                        productUpd.Price = productUpd.Price*koeff;
                        context.SaveChanges();
                    }
                    // context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelReval(WaybillBM model)
        {

        }

        public WaybillBM GetElement(int id)
        {
            throw new NotImplementedException();
        }

        public List<WaybillBM> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdReval(WaybillBM model)
        {
            throw new NotImplementedException();
        }

        public int CalcCount(int  idProd)
        {
            List<WaybillBM> waybills = context.Waybills.Select(rec => new WaybillBM
            {
                Id = rec.Id,
                TypeOfWaybillId = rec.TypeOfWaybillId
            }).ToList();
            
            
                Product prod = context.Products.FirstOrDefault(rec => rec.Id == idProd);
                double price = prod.Price;
                haves = 0;

                foreach (WaybillBM wb in waybills)
                {
                    if (wb.TypeOfWaybillId == 2)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == idProd)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves += p.Count;
                        }
                    }

                    if (wb.TypeOfWaybillId == 3 || wb.TypeOfWaybillId == 4)
                    {
                        List<ProductWaybillBM> productWaybills = context.ProductWaybills.Select(rec => new ProductWaybillBM
                        {
                            Id = rec.Id,
                            ProductId = rec.ProductId,
                            WaybillId = rec.WaybillId,
                            Count = rec.Count
                        }).Where(rec => rec.WaybillId == wb.Id & rec.ProductId == idProd)
                        .ToList();

                        foreach (ProductWaybillBM p in productWaybills)
                        {
                            haves -= p.Count;
                        }
                    }
                }
            return haves;
        }
    }
}
