﻿namespace PMS_Api.Model.Requests;

public record EditTemplateRequest(int TemplateId, string NewTemplateName, Guid NewClientId, int NewProjectTypeId, string NewFormat);
