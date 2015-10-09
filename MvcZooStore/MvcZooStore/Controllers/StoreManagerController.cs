using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcZooStore.Models;
using System.Xml;
using System.IO;


namespace MvcZooStore.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private ZooStoreEntities db = new ZooStoreEntities();

        //
        // GET: /StoreManager/       
        public ViewResult Index()
        {
            var petss = db.Pets.ToList();
            
            XmlTextWriter textWriter = new XmlTextWriter("C:\\PetsXml.xml", null);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Table");

            foreach (var r in petss)
            {
                {
                    textWriter.WriteStartElement("Pet");
                        textWriter.WriteStartElement("PetID", "");
                        textWriter.WriteString(Convert.ToString(r.PetID));
                        textWriter.WriteEndElement();
                        textWriter.WriteStartElement("Title", "");
                        textWriter.WriteString(Convert.ToString(r.Title));
                        textWriter.WriteEndElement();
                        textWriter.WriteStartElement("Description", "");
                        textWriter.WriteString(Convert.ToString(r.Description));
                        textWriter.WriteEndElement();
                        textWriter.WriteStartElement("PetArtUrl", "");
                        textWriter.WriteString(Convert.ToString(r.PetArtUrl));
                        textWriter.WriteEndElement();
                        textWriter.WriteStartElement("Price", "");
                        textWriter.WriteString(Convert.ToString(r.Price));
                        textWriter.WriteEndElement();
                    textWriter.WriteEndElement();
                }
            }
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
            
            /////////////////////////////////////////////////////////////////
            var pets = db.Pets.Include(p => p.Kind).Include(p => p.Company);
            return View(pets.ToList());
        }

        //test
        public ActionResult Test()
        {
        return RedirectToAction("Index", "StoreManager");
        }
        //
        // GET: /StoreManager/Details/5

        public ViewResult Details(int id)
        {
            Pet pet = db.Pets.Find(id);
            return View(pet);
        }

        //
        //GET: /StoreManager/XML
         [HttpPost]
        public ViewResult XML()
        {
            
           /* saveFileDialog1.Filter = "XML file|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LinqConnection con = new OleDbConnection();
                con.ConnectionString =
                    "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFileDialog1.FileName;

                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from " + db.Pets, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "" + comboBox1.SelectedItem);
                ds.WriteXml(saveFileDialog1.FileName);
                MessageBox.Show("XML файл создан:" + saveFileDialog1.FileName + ".xml");
                con.Close();
            }*/
            return View();
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.KindID = new SelectList(db.Kinds, "KindID", "Name");
            ViewBag.CompanyID = new SelectList(db.Companies, "CompanyID", "Name");
            return View();
        }

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(pet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KindID = new SelectList(db.Kinds, "KindID", "Name", pet.KindID);
            ViewBag.CompanyID = new SelectList(db.Companies, "CompanyID", "Name", pet.CompanyID);
            return View(pet);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id)
        {
            Pet pet = db.Pets.Find(id);
            ViewBag.KindID = new SelectList(db.Kinds, "KindID", "Name", pet.KindID);
            ViewBag.CompanyID = new SelectList(db.Companies, "CompanyID", "Name", pet.CompanyID);
            return View(pet);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KindID = new SelectList(db.Kinds, "KindID", "Name", pet.KindID);
            ViewBag.CompanyID = new SelectList(db.Companies, "CompanyID", "Name", pet.CompanyID);
            return View(pet);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id)
        {
            Pet pet = db.Pets.Find(id);
            return View(pet);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet pet = db.Pets.Find(id);
            db.Pets.Remove(pet);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}