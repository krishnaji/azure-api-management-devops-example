﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates
{
    public class Template
    {
        [JsonProperty(PropertyName = "$schema")]
        public string schema { get; set; }
        public string contentVersion { get; set; }
        public Dictionary<string, TemplateParameterProperties> parameters { get; set; }
        public object variables { get; set; }
        public TemplateResource[] resources { get; set; }
        public object outputs { get; set; }
    }

    public class TemplateParameterProperties {
        public string type { get; set; }
        public TemplateParameterMetadata metadata { get; set; }
        public string[] allowedValues { get; set; }
        public string defaultValue { get; set; }
        public string value { get; set; }
        public int minLength { get; set; }
    }

    public class TemplateParameterMetadata {
        public string description { get; set; }
    }
    
    public class TemplateResource {
        public string name { get; set; }
        public string type { get; set; }
        public string apiVersion { get; set; }
        public string scale { get; set; }
        public string[] dependsOn { get; set; }
    }
}