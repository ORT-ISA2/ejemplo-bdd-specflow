# Ejemplo - BDD con SpecFlow

## Guía de creación del proyecto (manualmente)

1. Nuevo proyecto: Biblioteca de clases + .Net 5.0
2. Cambiar nombre de Class1.cs a Calculator.cs
3. Agregar proyecto de MSTest - .Net 5.0
4. Agregar dependencias

    a. NuGet Packages: SpecFlow + SpecFlow.MsTest + SpecFlow.Plus.LivingDocPlugin + FluentAssertions
    
    b. Dependencia con la solución: CalculatorExample
 
5. Agregar carpetas para Features + Steps
7. Crear nuevo archivo de definición de feature: Nuevo archivo -> SpecFlow -> SpecFlow Feature
8. Crear nuevo archivo de definición de pasos: Nuevo archivo -> SpecFlow -> SpecFlow Step Definition
9. Implementar los métodos necesarios

## Guía para ver resultados

1. Instalar livingDoc --> dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
2. Moverse al directorio de salida de los tests --> Calculator/CalculatorTests/bin/Debug/net5.0
3. Ejecutar el comando para generar html --> livingdoc test-assembly CalculatorTests.dll -t TestExecution.json
4. En la misma carpeta se encontrará el hml generado con un formato similar al siguiente

![Tests Results](https://github.com/ORT-ISA2/ejemplo-bdd-specflow/blob/main/assets/tests-results-example.png)


## Links de referencias
- SpecFlow: https://docs.specflow.org/projects/specflow/en/latest/
- Guía paso a paso de SpecFlow: https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step1.html
- FluentAssertions: https://fluentassertions.com/
- Correr test con SpecFlow en Github Actions: https://github.com/marketplace/actions/run-specflow-tests
