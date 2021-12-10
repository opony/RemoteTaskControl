class RemoteTaskControlTest{
  public void TestRemoteTask()
  {
      string server = "serverhost";
      string username = "username";
      string domain = "domain";
      string password = "password";
      // windows 2008 , library use ver 2, flag = false
      //using (var ts = new TaskService(server, username, domain, password, false))
      //{
      //    //return ts.GetRunningTasks(true).FirstOrDefault(t => t.Name == "taskName") != null;
      //    Debug.WriteLine(ts);
      //    Console.WriteLine("");
      //}

      // windows 2003 , library use ver 1, flag = true
      var ts = new TaskService(server, username, domain, password, true);
      foreach (Task task in ts.GetFolder("Microsoft").Tasks)
      {
          if (task.Name == "pony_test")
          {
              //task.Stop();
              task.Run();
          }
          Debug.WriteLine(task.Name);
          Console.WriteLine("");
          //do things
      }
  }
}
