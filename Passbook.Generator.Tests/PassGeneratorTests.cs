﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Passbook.Generator.Tests
{
    [TestClass]
    public class PassGeneratorTests
    {
        [TestMethod]
        public void RealTest()
        {
            PassGeneratorRequest request = new PassGeneratorRequest();
            request.Identifier = "R5QS56362W.pass.tomasmcguinness.com";
            request.FormatVersion = 1;
            request.SerialNumber = "121212";
            request.Description = "My first pass";
            request.OrganizationName = "Tomas McGuinness";
            request.TeamIdentifier = "Team America";
            request.LogoText = "My Pass";
            request.BackgroundColor = "rgb(23, 187, 82)";

            request.IconFile = @"icon.png";
            request.IconRetinaFile = @"Icon@2x.png";
            request.LogoFile = @"logo.png";
            request.LogoRetinaFile = @"logo@2x.png";

            request.Event = new EventTicket();
            request.Event.PrimaryFields = new System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>();
            request.Event.PrimaryFields.Add(new System.Collections.Generic.Dictionary<string, string>());
            request.Event.PrimaryFields[0].Add("key", "event-name");
            request.Event.PrimaryFields[0].Add("value", "Amazing Event");

            request.AddBarCode("http://test", BarcodeType.PKBarcodeFormatQR, "iso-8859-1", "BarCode AltText");

            PassGenerator generator = new PassGenerator();
            generator.Generate(request);
        }
    }
}
