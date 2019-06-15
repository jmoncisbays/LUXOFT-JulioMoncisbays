import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'headlinePreview'
})
export class HeadlinePreviewPipe implements PipeTransform {

  transform(value: string): string {
    return value.length > 50 ? value.substring(0, 50) + "..." : value;
  }

}
