﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ResumeDtos;

public class ForFileResumeDto
{
    public IFormFile File { get; set; } = null!;
}
