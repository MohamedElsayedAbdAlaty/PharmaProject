import { Component, ElementRef, ViewChild } from '@angular/core';
import { HttpService } from './Core/http.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'pharma';
  @ViewChild('labelImport')labelImport: ElementRef;
  constructor(public http:HttpService)
  {  }
   formData = new FormData();
  onFileChanged(event)
  {
    if (event.target.files.length > 0) {
      const file = event.target.files[0];
      const formData = new FormData();
      this.labelImport.nativeElement.innerText=file.name;
      this.formData.append('file', file, file.name);
    }
  }
  onUpload(){
    this.http.Post('api/SellerProduct/post',this.formData )
    .subscribe(result=>{
      console.log(result)
      },
  );
  }
  onUpdate()
  {
    this.http.Get('api/SellerProduct/update' )
    .subscribe(result=>{
      console.log(result)
      },
  );
  }
}
