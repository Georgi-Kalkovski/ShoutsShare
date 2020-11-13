using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShoutsShare.Web.Controllers
{
    public class FilesController : Controller
    {
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload(List<IFormFile> files)
        {
            var filePath = Path.GetTempFileName(); // Full path to file in temp location

            foreach (var formFile in files.Where(f => f.Length > 0))
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }
            } // Copy files to FileSystem using Streams

            var bytes = files.Sum(f => f.Length);
            return this.Ok(new { count = files.Count, bytes, filePath });
        }
    }
}
