# Resolveing Merge Conflicts
- Merge conflicts occur when a person needs to make a decision.
- Merge conflicts can only occur if the same file is changed.
- Git automatically merges changes to different parts (hunks) of files.

**Avoiding Merge Conflicts**
- Git merges are usually quite easy
- Small, frequenr merges are the easiest

**Resolving a merge conflict**
Involves three commits:
1. The tip of the current branch - "ours" or "mine"
2. The tip of the branch to be merged - "theirs"
3. A common ancestor - "merge base"

**Basic steps to resolve a merge conflict**
1. Checkout master
2. Merge featureX
    a. CONFLICT - Both modified fileA.txt
3. Fix fileA.txt
4. Stage fileA.txt
5. Commit the merge commit
6. Delete the featureX branch label

When attempting a merge, files with conflicts are modified by Git and placed in the working tree

**Merge Conflict**
```
$ git log --oneline --graph --all
* c1633f9 (HEAD -> master) added feature 3
| * 942b91e (feature2) added feature 2
|/
* c431e4b added feature 1
$ git merge feature2
Auto-merging fileA.txt
CONFLICT (content): ....
$ git status
On branch master
You have unmerged paths.
...
```

**Conflicted Hunks**
Conflicted hunks are surrounded by conflict marker <<<<<<< and >>>>>>>

```
fileA.txt
feature 1
<<<<<<< HEAD
feature 3
=======
feature 2
>>>>>>> feature2
```

**Reading Conflict Markers**
- Text from the HEAD commit is between <<<<<<< and =======
- Text from the branch to be merged is between ======= and >>>>>>>

**Fix and Commit the Merge**
```
$ cat fileA.txt
feature 1
feature 2
feature 3
$ git add fileA.txt
$ git commit
$ git log --oneline --graph --all
$ git branch -d feature2
```

**REVIEW**
- Merge conflicts occur when two branches modify the same hunk
- When a conflict occurs:
    - Git will create files in the working tree containing conflict markers
    - Fix, add and commit the conflicted files


# Tracking Branches
A local branch that represents a remote branch
`<remote>/<branch>`

![alt text](./images/tracking_branch.png)

Tracking branches - related but decoupled

**Viewing Tracking Branch Names**
`git branch --all`
Displays local and tracking branch names

```
$ git clone https://...
$ cd projecte
$ git branch
* master
$ git branch --all
* master
  remotes/origin/HEAD -> origin/master
  remotes origin/master
```

**remotes/origin/HEAD**
Specifies the default remote tracking branch
- Allows `<remote>` to be specified of `<remote>/<branch>` in Git commands
```
$ git branch --all
* master
  remotes/origin/HEAD -> origin/master
  remotes/origin/master
$ git log origin/master --oneline
215b50a (origin/master, origin/HEAD) add feature 1
f92ad48 (HEAD -> master) add fileA.txt
$ git log origin --oneline
215b50a (origin/master, origin/HEAD) add feature 1
f92ad48 (HEAD -> master) add fileA.txt
```