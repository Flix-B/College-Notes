# GIT

## What is GIT?

GIT is a VCS (Version Control System)
System that stores a local dir of a root file and version files
3 states of a GIT files modification: 
-Modified (you have modified a file but not commitec it to your local database yet)
-Staged (You have marked the current modified file to go into the next commit snapshot
-Commited (The data is securely stored in your local database)

## GIT Branching

when a project is being develeoped,
branches can exist that branch off of the main version 
and later remerge into the main.
                  
Example:     
                   Main 
==================================================================
            --          --            --              --
              ---------                 --------------
                branch1                     branch2


## GIT Commands/info

git status - displays current status of git repository
git init -  creates a hidden folder called ".git" (do not touch)
git add <filename> - tells database to track file(s)
git commit -m <comment>
git log - lists commits
git checkout <branchname> - allows access to old versions or all current branches
git checkout -b  - creates a new branch from the one you are currently in.
git branch - creating new branch
git pull - pulls data frpm repository
git push - pushes data to repository
git clone - used when no local copy of repository exists
~/scr folder (source) to put all GIT stuff in 

##To Do

READ: GIT basics, GIT branching
