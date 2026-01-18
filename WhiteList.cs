using System;
using System.Collections.Generic;

// AUTOMATICKY VYGENEROVANÝ KÓD - NEUPRAVOVAT RUČNĚ!
// WhiteList - povolené custom soubory (skiny, mapy, módy)
// Vygenerováno: 2026-01-18 15:14:20
// Počet souborů: 1

public class FileMetadata
{
    public long Size { get; set; }
}

public class WhiteList
{
    public static readonly Dictionary<string, FileMetadata> AllowedFiles = new Dictionary<string, FileMetadata>
    {
        [@"testwhitelist.cbf"] = new FileMetadata { Size = 723479L },
    };
}
