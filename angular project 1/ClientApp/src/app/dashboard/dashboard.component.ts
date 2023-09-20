import { Component } from '@angular/core';
interface User {
  xp: number;
  guild: string;
}

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  user: User = {
    xp: 100,
    guild: 'Adventurers'
  };
}
