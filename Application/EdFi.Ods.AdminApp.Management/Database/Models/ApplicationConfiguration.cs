﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace EdFi.Ods.AdminApp.Management.Database.Models
{
    public class ApplicationConfiguration : Entity
    {
        public bool AllowUserRegistration { get; set; }

        public bool FirstTimeSetUpCompleted { get; set; }

        public bool EnableProductImprovement { get; set; }

        public string ProductRegistrationId { get; set; }
    }
}