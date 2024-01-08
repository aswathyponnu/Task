import { Component } from '@angular/core';
import { Task } from '../models/tasks';
import { ApiService } from '../app.service';


@Component({
  selector: 'app-task',
  standalone: true,
  imports: [],
  templateUrl: './task.component.html',
  styleUrl: './task.component.css'
})
export class TaskComponent {
  constructor(private apiService: ApiService) {}

  hero: Task = {}

  onClick(){

  }
}
