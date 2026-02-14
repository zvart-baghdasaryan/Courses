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
