
//{
//    [Area("Admin")]
//    public IActionResult Index()
//    {
//        return View();
//    }
//    public IActionResult CategoryChart()
//    {
//        List<CategoryClass> list = new List<CategoryClass>();

//        list.Add(new CategoryClass
//        {
//            categoryname = "Teknoloji",
//            categorycount = 10
//        });
//        list.Add(new CategoryClass
//        {
//            categoryname = "Yazılım",
//            categorycount = 14
//        });
//        list.Add(new CategoryClass
//        {
//            categoryname = "Spor",
//            categorycount = 5
//        });
//        return Json(new { jsonlist = list });
//    }
//}
//}


//< div class= "row" >
//    < div class= "col-lg-12" >
//        < div id = "chartdiv" style = "width:800px; height:600px" >
//            < h2 > Burası Chart Alanıdır</h2>
//        </div>
//    </div>
//</div>
//<script type = "text/javascript" src= "https://www.gstatic.com/charts/loader.js" ></ script >
//< script type= "text/javascript" >
//    google.charts.load('current', { 'packages': ['corechart'] });
//google.charts.setOnLoadCallback(DrawonLoad);

//function DrawonLoad()
//{
//        $(function()
//        {
//            $.ajax(
//                {
//        type: 'GET',
//                    url: '/Admin/Chart/CategoryChart/',
//                    success: function(chartsdata)
//                    {
//                var Data = chartsdata.jsonlist;
//                var data = new google.visualization.DataTable();

//                data.addColumn('string', 'categoryname');
//                data.addColumn('number', 'categorycount');

//                for (var i = 0; i < Data.length; i++)
//                {
//                    data.addRow([Data[i].categoryname, Data[i], categorycount]);
//                        }
//                        var chart = new.google.visualization.PieChart(document.getElementById('chartdiv'));

//chart.draw(data,
//                            {
//title: "Google Chart Projesi",
//                                position: "top",
//                                fontsize: "16px"
//                            });
//                    }
//                });
//        })
//    }


//</ script >