using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class Manager
    {
        // Reference to the data context
        private DataContext ds = new DataContext();

        public Manager()
        {
            // If necessary, add constructor code here
        }

        // Add methods below
        // Controllers will call these methods
        // Ensure that the methods accept and deliver ONLY view model objects and collections
        // The collection return type is almost always IEnumerable<T>

        // Suggested naming convention: Entity + task/action
        // For example:
        //EmployeeGetAll()
        public IEnumerable<EmployeeBase> EmployeeGetAll()
        {
            var results = new List<EmployeeBase>();
            var allEmployees = ds.Employees;

            foreach (var employee in allEmployees)
            {
                var e = new EmployeeBase();
                e.Address = employee.Address;
                e.BirthDate = employee.BirthDate;
                e.City = employee.City;
                e.Country = employee.Country;
                e.Email = employee.Email;
                e.EmployeeId = employee.EmployeeId;
                e.Fax = employee.Fax;
                e.FirstName = employee.FirstName;
                e.LastName = employee.LastName;
                e.HireDate = employee.HireDate;
                e.Phone = employee.Phone;
                e.PostalCode = employee.PostalCode;
                e.State = employee.State;
                e.Title = employee.Title;

                results.Add(e);
            }
            return results;
        }
        // EmployeeGetOne()
        public EmployeeBase EmployeeGetOne(int? id)
        {
            var e = ds.Employees.Find(id);
            return (e == null) ? null : Mapper.Map<Employee, EmployeeBase>(e);
        }
        // ProductAdd()
        public EmployeeBase EmployeeAdd(EmployeeAdd newItem)
        {
            var addedItem = ds.Employees.Add(Mapper.Map<EmployeeAdd, Employee>(newItem));
            ds.SaveChanges();

            return (addedItem == null) ? null : Mapper.Map<Employee, EmployeeBase>(addedItem); 

        }
        // ProductEdit()
        public EmployeeBase EmployeeEditContactInfo(EmployeeEditContactInfo newItem)
        {
            var o = ds.Employees.Find(newItem.EmployeeId);

            if (o == null)
            {
                return null;
            }
            else
            {
                ds.Entry(o).CurrentValues.SetValues(newItem);
                ds.SaveChanges();
            }
            return Mapper.Map<Employee, EmployeeBase>(o);
        }

        // ProductDelete()
        public bool EmployeeDelete(int id)
        {
            // Attempt to fetch the object to be deleted
            var itemToDelete = ds.Employees.Find(id);

            if (itemToDelete == null)
            {
                return false;
            }
            else
            {
                // Remove the object
                ds.Employees.Remove(itemToDelete);
                ds.SaveChanges();

                return true;
            }
        }

        public IEnumerable<TrackBase> TrackGetAll()
        {

            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(ds.Tracks);


            /*           var results = new List<TrackBase>();
                        var allTracks = ds.Tracks;

                        foreach (var track in allTracks)
                        {
                            var t = new TrackBase();

                            t.TrackId = track.TrackId;
                            t.Name = track.Name;
                            t.AlbumId = track.AlbumId;
                            t.MediaTypeId = track.MediaTypeId;
                            t.GenreId = track.GenreId;
                            t.Composer = track.Composer;
                            t.Milliseconds = track.Milliseconds;
                            t.Bytes = track.Bytes;
                            t.UnitPrice = track.UnitPrice;

                            results.Add(t);
                        }
                        return results;
            */
        }

        public IEnumerable<TrackBase> TrackGetAllPop()
        {
            var t = ds.Tracks.Where(o => o.GenreId == 9).OrderBy(o => o.Name);

            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(t);

            /*          var results = new List<TrackBase>();
                        var allTracks = ds.Tracks.Where(o => o.GenreId == 9).OrderBy(o => o.Name);

                        foreach (var track in allTracks)
                        {
                            var t = new TrackBase();

                            t.TrackId = track.TrackId;
                            t.Name = track.Name;
                            t.AlbumId = track.AlbumId;
                            t.MediaTypeId = track.MediaTypeId;
                            t.GenreId = track.GenreId;
                            t.Composer = track.Composer;
                            t.Milliseconds = track.Milliseconds;
                            t.Bytes = track.Bytes;
                            t.UnitPrice = track.UnitPrice;

                            results.Add(t);
                        }
                        return results;
            */
        }
        public IEnumerable<TrackBase> TrackGetDeepPurple()
        {

            var t = ds.Tracks.Where
                    (tr => tr.Composer.ToLower().Contains("Jon Lord".Trim().ToLower()));
            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(t.OrderBy(tr => tr.TrackId));
        }
        public IEnumerable<TrackBase> TrackGetAllTop100Longest()
        {
            var t = ds.Tracks.OrderByDescending(tr => tr.Milliseconds).Take(100);
            return Mapper.Map<IEnumerable<Track>, IEnumerable<TrackBase>>(t);
        }


    }
}