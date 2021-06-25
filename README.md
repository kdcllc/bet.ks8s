# bet.ks8s

The goal of this repo is two fold:

1. GitHub Actions Docker Images build and deployment
2. To publish nuget packages to feedz.io from dev branch with versioning and nuget.org on master page.

## Goals

- Setup Github action for nuget packages
- Setup Github action for docker build

- Create a test webapi HPA test in the cluster

```bash
    # initialization
    dotnet tye init

    # runs locally
    dotnet tye run

    # generates simple deployment yaml
    dotnet tye generate
    
    # deploys
    dotnet tye deploy  -v Debug
    
    # displays resources that would be deleted
    dotnet tye undeploy --what-if
```

```bash
     kubectl port-forward pods/bet-k8s-api-554d7967df-68z5v 5080:80 -n bet
```

```bash
    
```

Download [bombardier/](https://github.com/codesenberg/bombardier/releases)

```bash
    bombardier --duration=60s --rate=20 --timeout=20s https://betapi.kingdavidconsulting.com

    kubectl api-versions

    bombardier --duration=5m --rate=100 --timeout=20s https://betapi.kingdavidconsulting.com
    
```

## References

- [MinimalApiPlayground](https://github.com/DamianEdwards/MinimalApiPlayground)
- [minimalApiWithSwagger](https://github.com/bradygaster/minimalApiWithSwagger)
- [swagger](https://github.com/halter73/swagger)
- [Daily .NET Core SDK builds](https://github.com/dotnet/installer#installers-and-binaries)
- [Horizontal Pod Autoscaler Walkthrough](https://kubernetes.io/docs/tasks/run-application/horizontal-pod-autoscale-walkthrough/)
- [Getting started with K8s HPA & AKS Cluster Autoscaler](https://www.fearofoblivion.com/getting-started-with-k8s-hpa-and-aks-cluster-autoscaler)