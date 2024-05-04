using System;
using System.Collections.Generic;

namespace PMS_Api.Model;

public partial class KampaniaMailingowaStatystyka
{
    public int Id { get; set; }

    public string? Data { get; set; }

    public int? IloscWejsc { get; set; }

    public int? KampaniaMailingowaId { get; set; }
}
