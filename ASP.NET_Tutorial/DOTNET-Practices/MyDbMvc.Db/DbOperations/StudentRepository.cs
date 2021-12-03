using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMvc.Models;

namespace MyDbMvc.Db.DbOperations
{
    public class StudentRepository
    {
        //To Insert/Add/Save record into Student Table
        public int AddEmployee(StudentModel model)
        {
            using(var context = new StudentDBEntities())
            {
                Student stud = new Student()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    RollNo = model.RollNo,
                    
                };
                if (model.Address != null)
                {
                    stud.Address = new Address()
                    {
                        Street = model.Address.Street,
                        State = model.Address.State,
                        Country = model.Address.Country
                    };
                }
                context.Student.Add(stud);
                context.SaveChanges();
                return stud.Id;
            }
        }

        //To get all Data from Database
        public List<StudentModel> GetAllStudent()
        {
            using (var context = new StudentDBEntities())
            {
                var result = context.Student.Select(x => new StudentModel() { 
                    Id = x.Id,
                    AddressId = x.AddressId,
                    RollNo = x.RollNo,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = new AddressModel()
                    {
                        Id = x.Address.Id,
                        Street = x.Address.Street,
                        State = x.Address.State,
                        Country = x.Address.Country
                    }
                
                }).Take(100).ToList(); //here multiple data will be returned in list form and first 100 records shown.
                return result;
            }
        }

        //To get One Data from Database
        public StudentModel GetOneStudent(int id)
        {
            using (var context = new StudentDBEntities())
            {
                var result = context.Student.Where(x=>x.Id == id).Select(x => new StudentModel()
                {
                    Id = x.Id,
                    AddressId = x.AddressId,
                    RollNo = x.RollNo,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Address = new AddressModel()
                    {
                        Id = x.Address.Id,
                        Street = x.Address.Street,
                        State = x.Address.State,
                        Country = x.Address.Country
                    }

                }).FirstOrDefault(); //here one record is returned in list form.
               return result;
            }
        }

        ////To Edit record in database, here 2 hit occurs onto database
        //public bool UpdateStudent(int id,StudentModel model)
        //{
        //    using (var context = new StudentDBEntities())
        //    {
        //        var result = context.Student.FirstOrDefault(s => s.Id == id);
        //        if(result != null)
        //        {
        //            result.FirstName = model.FirstName;
        //            result.LastName = model.LastName;
        //            result.Email = model.Email;
        //            result.RollNo = model.RollNo;
        //        }
        //        context.SaveChanges();
        //        return true;
        //    }
        //}

        //To Edit record in database, With 1 hit onto database
        public bool UpdateStudent(int id, StudentModel model)
        {
            using (var context = new StudentDBEntities())
            {
                var result = new Student
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    RollNo = model.RollNo,
                    AddressId = model.AddressId
                };

                context.Entry(result).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        //To Delete record from database, Here 2 hit occurs
        //public bool DeleteStudent(int id)
        //{
        //    using (var context = new StudentDBEntities())
        //    {
        //        var result = context.Student.FirstOrDefault(s => s.Id == id);
        //        if(result != null)
        //        {
        //            context.Student.Remove(result);
        //            context.SaveChanges();
        //            return true;
        //        }
        //        return false;

        //    }
        //}
        //OR
        //To Delete record from database, With 1 hit to database.
        public bool DeleteStudent(int id)
        {
            using (var context = new StudentDBEntities())
            {
                var stud = new Student()
                {
                    Id = id
                };
                context.Entry(stud).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return false;

            }
        }
    }
}
