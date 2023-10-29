# 🚆 TrainCloud.Uic

The 'TrainCloud.Uic' library provides UicNumberService to work with UIC numbers

## GitHub Actions
[![Tests](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/tests.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/tests.yml) 
[![NuGet](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/nuget.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/nuget.yml) 
[![SonarQube](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/sonarqube.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/sonarqube.yml)

## SonarQube
[![Bugs](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=bugs&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Code Smells](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=code_smells&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Coverage](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=coverage&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Duplicated Lines (%)](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=duplicated_lines_density&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Lines of Code](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=ncloc&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Maintainability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=sqale_rating&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Quality Gate Status](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=alert_status&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Reliability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=reliability_rating&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Security Hotspots](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=security_hotspots&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Security Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=security_rating&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Technical Debt](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=sqale_index&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Vulnerabilities](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=vulnerabilities&token=sqb_452552b8fb07fffa84c1732d8def596c513ccf85)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic)

## How to use

```bash
dotnet add package Traincloud.Uic
```

```csharp
protected IUicNumberService UicNumberService { get; init; }
```

```
@inject IUicNumberService UICService
```