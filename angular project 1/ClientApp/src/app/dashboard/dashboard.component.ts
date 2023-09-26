import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  public userinfo: Userdto;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Userdto>(baseUrl + 'user').subscribe(result => {
      this.userinfo = result;
    }, error => console.error(error));
  }
  
}
interface Userdto {
  guild: string;
  xp: number;

}

