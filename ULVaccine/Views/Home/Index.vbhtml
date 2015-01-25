@Code
    ViewData("Title") = "Home Page"
End Code



<head>
    <title>
        Home Page
    </title>
    <link rel="stylesheet" type="text/css" href="~/Content/CSS/HomeStyle.css">
</head>

<br />
<br />
<br />
<br />
<br />
<br />
<div class="row">
    <div class="col-md-2">
            <p>
                <div class="btn-group-vertical btn-group-lg" aria-label="...">

                        <a class="btn dropdown-toggle" data-toggle="dropdown" role="button" href="www.google.com"><img src="~/Content/Images/Syringe.png" alt="Inventory" style="width:75px; height:50px" />
                            <br />Inventory &raquo;<i class="icon icon-caret-right"></i>
                        </a>
                    <ul class="dropdown-menu">
                        <li>Add Vaccine</li>
                        <li>Modify Vaccine</li>
                        <li>Delete Vaccine</li>
                    </ul>
 
                    
                    
                    <a class="btn btn-default" role="button"><img src="~/Content/Images/Calendar.jpg" alt="Inventory" style="width:75px; height:50px" /><br />Scheduling &raquo;</a>
                    
                    
                    <a class="btn btn-default" role="button"><img src="~/Content/Images/Document.png" alt="Inventory" style="width:75px; height:50px" /><br />Grants &raquo;</a>
                    
                    
                    <a class="btn btn-default" role="button"><img src="~/Content/Images/User.png" alt="Inventory" style="width:75px; height:50px" /><br />Users &raquo;</a>
                </div>
            </p>
    </div>
    <div class="col-md-2"></div>
    <div class="col-md-4">
        <p> middle section</p>
    </div>
    <div class="col-md-4">
        <p> right section</p>
    </div>
</div>
