import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MyUserASMT';
  users: any; //users could be any type

  constructor(private http: HttpClient){}

		  //this life cycle even must always come after the constructor
  ngOnInit() {
    this.getUsers();
  }

  getUsers(){
    this.http.get('https://localhost:5001/api/users').subscribe(response =>{
        this.users = response;
    }, error => {
      console.log(error);
    })
  } //=> are array functions
}
