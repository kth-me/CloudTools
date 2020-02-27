## About
Cloud Tools is a Package/Plugin designed for Microsoft IDE's being developed in C♯/.NET. It is yet to be determined if this will be supported by other IDE's down the line. 

Cloud Tools is designed to help with the development of projects, git, repo management, branch to instance/shard mapping and CI/CD pipeline management. The tool is also aimed for fast migrations and development optimizations e.g. easily move instances between servers or providers. 
 
## Plan
The Plan is to start by first setting up easy git mirroring over different repos allowing for repos being syncrhonized during development.
This tool is designed to be indifferent of programming languages for repo management to allow faster development. Once repos are mapped to Cloud services and devops/pipelines, it will then be language dependent meaning only certain languages will be supported for deployments as the tool progresses.

Eventually the Team will grow from 1 member to a community allowing features to be implemented more rapidly by developers for developers. All developers who publish a major feature or major update may have their name appended to the beerware license as an acknowledgement.

<img src="https://github.com/kth-me/CloudTools/blob/master/VS%20tool.jpg">

## Installation
Upon Release, the extension will be released for Visual Studio and Visual Code for developers. Informaiton on installation will be disclosed at a later date.

## Usage
The tool is designed to allow developers to manage their Git repos, Pipelines and Devops with Cloud Computing whilst in their IDE.
To prove the tool works, eventually this tool will manage its own repo aswell as a sample project.
As per licensing, the tool is allowed commercially to develop projects and/or platforms of software. The tool itself is not allowed to be integrated into the said software unless it complies with the license described further down.

## Compatiable/Supported IDE's
- Visual Studio (Priority 1 - Compatiable but no automated testing of yet.)
- Visual Code (Priority 2 - Undertermined)
- JetBrains (TBD due to Language and interface limitations)

## Compatiable/Supported Git repos
By having the tool compatible with numerous Git repos this will allow for company to configure prefence of code repos and allow fast mirroring. Below is the list of what repositories are in progress or planned for future integrations:
- Git
- GitLab
- GitHub
- BitBucket
- Azure Devops
- AWS CodeCommit

Upon Git Mirroring and project management has been established, Team will most likely expand allowing for features to be assigned to developers. Specific branches of this open source project will use this mirroring to automate distribution amongst the public repos. 

## Compatiable/Supported Cloud Services

- AWS (Priority 1, Start after Git Mirroring is completed)
- Azure (Piority 2 )
- Google Cloud (Priority 3)

## Continous Integration and Continous Deployment for Cloud Computing.
This is being provided by the child open source project GitPipelines https://github.com/kth-me/GitPipelines
This service will be designed to generate portable and configurable pipelines.

## Our Service of Quality Code
As this project will be Open source the standard for quality of code will be established early on and determiend by linting. In near future StyleCop will be implemented to the source code to standardise the coding style.

## License
Released under the [GPL-3.0](LICENSE) license and <a href="https://en.m.wikipedia.org/wiki/Beerware">Beerware</a> license.
All developers who contribute code aknowledges that they give up the rights and provide it as open source under the same licensing above.
