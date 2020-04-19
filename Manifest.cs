﻿using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Common Widgets",
    Author = "Etch",
    Website = "https://etchuk.com",
    Version = "0.7.0"
)]

[assembly: Feature(
    Id = "Etch.OrchardCore.Widgets",
    Name = "Common Widgets",
    Description = "Provides widgets commonly found on web pages.",
    Dependencies = new[] { "OrchardCore.Widgets", "OrchardCore.Flows", "OrchardCore.Html", "Etch.OrchardCore.Fields.ResponsiveMedia" },
    Category = "Content"
)]