import os
import sys

leng = len(sys.argv)
if leng < 3:
    raise IndentationError()
name = sys.argv[1]
entityname = sys.argv[2]

namespacebase = 'RLCore.RLAppService'
if leng > 3:
    namespacebase = sys.argv[3]

jtAsyncCrudAppService = 'RLCore.Services'
if leng > 4:
    jtAsyncCrudAppService = sys.argv[4]

thisnamespace = namespacebase + '.' + name

os.mkdir(name)

with open(name + '/' + name + 'AppService.cs', mode="w",
          encoding="utf-8") as f:
    f.write('using Abp.Domain.Repositories;\r')
    f.write('using ' + thisnamespace + '.Dtos;\r')
    f.write('using ' + jtAsyncCrudAppService + ';\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '\r')
    f.write('{\r')
    f.write('    public class ' + name + 'AppService\r')
    f.write('        : JTAsyncCrudAppService<' + entityname + ', ' + name +
            'Output, int, GetPagedInput, CreateInput, UpdateByIdInput>,\r')
    f.write('        I' + name + 'AppService\r')
    f.write('    {\r')
    f.write('        public ' + name + 'AppService(IRepository<' + entityname +
            '> repository)\r')
    f.write('            : base(repository)\r')
    f.write('        {\r')
    f.write('        }\r')
    f.write('    }\r')
    f.write('}\r')

with open(name + '/I' + name + 'AppService.cs', mode="w",
          encoding="utf-8") as f:
    f.write('using ' + thisnamespace + '.Dtos;\r')
    f.write('using ' + jtAsyncCrudAppService + ';\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '\r')
    f.write('{\r')
    f.write('    public interface I' + name + 'AppService\r')
    f.write('        : IJTAsyncCrudAppService<' + name +
            'Output, int, GetPagedInput, CreateInput, UpdateByIdInput>\r')
    f.write('    {\r')
    f.write('    }\r')
    f.write('}\r')

dtoDir = name + '/Dtos'
os.mkdir(dtoDir)

with open(dtoDir + '/CreateInput.cs', mode="w", encoding="utf-8") as f:
    f.write('using System;\r')
    f.write('using System.Collections.Generic;\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '.Dtos\r')
    f.write('{\r')
    f.write('    public class CreateInput\r')
    f.write('    {\r')
    f.write('\r')
    f.write('    }\r')
    f.write('}\r')

with open(dtoDir + '/GetPagedInput.cs', mode="w", encoding="utf-8") as f:
    f.write('using Abp.Application.Services.Dto;\r')
    f.write('using System;\r')
    f.write('using System.Collections.Generic;\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '.Dtos\r')
    f.write('{\r')
    f.write('    public class GetPagedInput : IPagedResultRequest\r')
    f.write('    {\r')
    f.write('        public int SkipCount { get; set; } = 0;\r')
    f.write('        public int MaxResultCount { get; set; } = 10;\r')
    f.write('    }\r')
    f.write('}\r')

with open(dtoDir + '/UpdateByIdInput.cs', mode="w", encoding="utf-8") as f:
    f.write('using Abp.Application.Services.Dto;\r')
    f.write('using System;\r')
    f.write('using System.Collections.Generic;\r')
    f.write('using System.ComponentModel.DataAnnotations;\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '.Dtos\r')
    f.write('{\r')
    f.write('    public class UpdateByIdInput : IEntityDto\r')
    f.write('    {\r')
    f.write('        [Required]\r')
    f.write('        public int Id { get; set; }\r')
    f.write('    }\r')
    f.write('}\r')

with open(dtoDir + '/' + name + 'Output.cs', mode="w", encoding="utf-8") as f:
    f.write('using Abp.Application.Services.Dto;\r')
    f.write('using System;\r')
    f.write('using System.Collections.Generic;\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '.Dtos\r')
    f.write('{\r')
    f.write('    public class ' + name + 'Output : EntityDto\r')
    f.write('    {\r')
    f.write('    }\r')
    f.write('}\r')

with open(dtoDir + '/' + name + 'MapProfile.cs', mode="w",
          encoding="utf-8") as f:
    f.write('using AutoMapper;\r')
    f.write('using System;\r')
    f.write('using System.Collections.Generic;\r')
    f.write('\r')
    f.write('namespace ' + thisnamespace + '.Dtos\r')
    f.write('{\r')
    f.write('    public class ' + name + 'MapProfile : Profile\r')
    f.write('    {\r')
    f.write('        public ' + name + 'MapProfile()\r')
    f.write('        {\r')
    f.write('            CreateMap<CreateInput, ' + entityname + '>();\r')
    f.write('            CreateMap<' + entityname + ', ' + name +
            'Output>();\r')
    f.write('            CreateMap<UpdateByIdInput, ' + entityname + '>();\r')
    f.write('        }\r')
    f.write('    }\r')
    f.write('}\r')