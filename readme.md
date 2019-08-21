# demo for how to run app as admin by app.manifest settings in build time

# how to?

- 1 select Winform App, Project, right click, add new item: select "app.manifest", OK
- 2 vs will auto create a file "app.manifest" under properties folder
- 3 edit "app.manifest", change [requestedExecutionLevel's level] from "asInvoker" to "requireAdministrator"
- 4 rebuild. DONE!

## change list

- 20190821 add and edit app.manifest
- 20190821 init project