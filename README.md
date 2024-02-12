# 🚆 TrainCloud.Uic

The `TrainCloud.Uic` library provides UicNumberService to work with [UIC numbers](https://en.wikipedia.org/wiki/UIC_wagon_numbers)

## Status

### GitHub Actions
[![Tests](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/tests.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/tests.yml) 
[![SonarQube](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/sonarqube.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/sonarqube.yml) 
[![NuGet](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/nuget.yml/badge.svg)](https://github.com/traincloud-net/TrainCloud.Uic/actions/workflows/nuget.yml) 

### SonarQube
[![Bugs](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=bugs&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Code Smells](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=code_smells&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Coverage](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=coverage&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Duplicated Lines (%)](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=duplicated_lines_density&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Lines of Code](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=ncloc&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Maintainability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=sqale_rating&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Quality Gate Status](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=alert_status&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Reliability Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=reliability_rating&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Security Hotspots](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=security_hotspots&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Security Rating](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=security_rating&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Technical Debt](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=sqale_index&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic) 
[![Vulnerabilities](https://sonarqube.traincloud.net/api/project_badges/measure?project=TrainCloud.Uic&metric=vulnerabilities&token=sqp_6e914db798355a6d5c593ef4cc0993c4d887c885)](https://sonarqube.traincloud.net/dashboard?id=TrainCloud.Uic)

## UIC numbers

AABBCCCCDDDX

* AA (Two digit car type code)
* BB (Two digit country code)
* CCCC (Four digit car class code)
* DDD (Three digit car class serial number)
* X (Checksum)

## How to use

Add github to nuget.config

```bash
dotnet add package Traincloud.Uic
```

```csharp
[inject]
protected IUicNumberService UicNumberService { get; init; }
```

```csharp
@inject IUicNumberService UICService
```