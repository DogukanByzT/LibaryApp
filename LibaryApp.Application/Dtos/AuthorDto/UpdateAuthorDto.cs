﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Dtos.AuthorDto
{
    public class UpdateAuthorDto : CreateAuthorDto
    {
        public int Id { get; set; }
    }

}
