
search();

function search() {
    var searchValue = document.getElementById("textFilterBook").value;
    fetch(`/api/books?filter=${searchValue}`)
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

   data.forEach((element) => populateTable(table, element));
   
}

function populateTable(table, item) {

      var row = document.createElement('tr');
        var td = document.createElement('td');
        console.log(item['title']);
        td.innerHTML = item['title'];
        row.appendChild(td);

        table.appendChild(row);
}