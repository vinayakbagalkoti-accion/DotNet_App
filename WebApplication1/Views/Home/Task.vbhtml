@Code
    ViewData("Title") = "Task"
End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<div class="jumbotron">
    <h3><b>Kindly enter the day to day tasks</b></h3>
    <br />
    <div class="row">
        <div class="col-lg-2"><label>Task</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>

    <div class="row">
        <div class="col-lg-2"><label>Status</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>

    <div class="row">
        <div class="col-lg-2"><label>Priority</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>

    <div class="row">
        <div class="col-lg-2"><label>Due Date</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>

    <div class="row">
        <div class="col-lg-2"><label>Assignee</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>

    <div class="row">
        <div class="col-lg-2"><label>Notes/Comments</label></div>
        <div class="col-lg-2"><input type="text" /></div>
    </div>
    <br />
    <div class="row">
        <div class="col-lg-1">
            <input type="button" value="Enter" />
            <input type="button" value="Cancel" />
        </div>
    </div>
</div>


