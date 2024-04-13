
search();

function search() {
    var searchBy = document.getElementById("searchBy").value;
    var searchValue = document.getElementById("textFilterBook").value;
    var isAvaiableNowFilter = searchBy == 5;
    if(searchBy == 0 && searchValue){
        alert("Please select an option in a search field");
    }

    if(searchBy > 0 && !searchValue && !isAvaiableNowFilter){
        alert("Please fill in a keyword");
    }

    if(isAvaiableNowFilter){
        document.getElementById("textFilterBook").value = "";
    }

    fetch(`/api/books?filter=${searchValue}&filterType=${searchBy}`)
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        SearchTableAndFill(data);
      })
      .catch(error => {
        console.error('Error:', error);
      });
}

function SearchTableAndFill(data){
    var table = document.getElementById('resultBooksTable');

    table.innerHTML = "";

    if(data.length == 0){
        var row = document.createElement('tr');
        var emptyTd = document.createElement('td');
        emptyTd.innerHTML = "No data found";
        table.appendChild(emptyTd);
    }

   data.forEach((element) => populateTable(table, element));
   
}

function populateTable(table, item) {

      var row = document.createElement('tr');

        var tdTitle = document.createElement('td');
        tdTitle.innerHTML = item['title'];

        var tdPublisher = document.createElement('td');
        tdPublisher.innerHTML = '';

        var tdAuthor = document.createElement('td');
        tdAuthor.innerHTML =  item['fullName'];

        var tdType = document.createElement('td');
        tdType.innerHTML = item['type'];

        var tdIsbn = document.createElement('td');
        tdIsbn.innerHTML = item['isbn'];

        var tdCategory = document.createElement('td');
        tdCategory.innerHTML = item['category'];

        var tdAvailableCopies = document.createElement('td');
        tdAvailableCopies.innerHTML = item['avaibleCopies'];

        row.appendChild(tdTitle);
        row.appendChild(tdPublisher);
        row.appendChild(tdAuthor);
        row.appendChild(tdType);
        row.appendChild(tdIsbn);
        row.appendChild(tdCategory);
        row.appendChild(tdAvailableCopies);

        table.appendChild(row);
}