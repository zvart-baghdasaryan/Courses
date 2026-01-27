# Installation and Getting Started

- Explore Git help
- Configure your user name, email adress and default editor

## Basic Git Syntax
`git [command] [--flags] [arguments]`

## Getting Help
To show the "full" help for a command:
`git help [command]`

- This is the same as the online documetation

[https://git-scm.com/docs/git-init](https://git-scm.com/docs/git-init)

```
$ git help init
(displayes help for the init command)
$ git help # or simply "git"
(displayes overall git help)
```

## Getting Concise Help
Concise help: `git <command> -h`

## Reading Help
`git fakecommand (-p | --patch) [<id>] [--] [<paths>...]`

- **-f** or **--flag** Change the command's behavior
- **|** Or
- **[optional]**
- **`<placeholder>`**
- **[`<optional placeholder>`]**
- **()** Grouping
- **--** Disambiguates the command
- **...** multiple occurrences possible

## Setting Your User Name and Email
`git config [--local | --global | --system] <key> [<value>]`

```
# set user name end email
$ git config --global user.name "Pat"
$ git config --global user.email "pat@example.com"
```

- The **--system** flag applies to every repository for all users on your computer
- The **--global** flag applies to every repository that you use on your computer
- No flag or **--local** applies only to the current repository (highest precedence)

## Reading Your User Name and Email
`git config <key>`

- The current value of `<key>` will be returned

```
# get user name
$ git config user.name
Pat
# get user email
$ git config uer.email
pat@example.com
```

## Setting Git's Default Editor
Specify an editor that you like to use by configuring **core.editor**

```
$ git config --global core.editor nano
```


# Git Location

![alt text](images\image.png)

- **working tree** - a single commit's directories and files
- **staging area/index** - files that are planned for the next commit
- **local repository** - contains the commits of the project
- **remote repository** - contains the commits of the project

# Create a Local Repository

`git init` - initialize (create) a repository

```
$ mkdir repos
$ cd repos
repos$ mkdir myproj
repos$ cd myproj
myproj$ git init
Initialized empty Git repository in myproj/.git/
myproj$ ls -a
.  ..  .git
```


## git status

Uset **git status** to view the status of files in the working tree and staging area

```
myproj$ git status
```
## git add
`git add <file-or-directory>`
![alt text](images\image-1.png)

Add all untracked or modified files using 
`git add .`

**Modified File** - Has been added to the stage and/or committed but then changes in the working tree

```
$ touch fileA.txt # create fileA.txt
$ git status -s # -s means short status
?? fileA.txt ## ?? means untrached
$ git add fileA.txt
$ git status -s
A fileA.txt # A means added (staged)
$ echo "feature 1" > fileA.txt # modify file.txt
$ git status -s
AM fileA.txt #AM means added and modified
$ git add fileA.txt
$ git status -s
A fileA.txt
```

## git commit
Adds staged content to the local repository as a commit
- Previously commited files are also included
- Created a snapshot of the entire project

![alt text](images\image-1.png)

```
$ git commit -m "initial commit"
```

## Viewing The Commit History With git log
```
$ git log
```

Limiting the size of git log

- -- oneline condensed version of the log
- # limits the log to the most recent # commits

```
$ git log --oneline
$ git log --oneline -2
```


