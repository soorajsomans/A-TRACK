@extends('layouts.app')
@section('content')
<div class="container">
    <div class="row">
        <div class="col-md-8 col-md-offset-2">

            <div class="panel panel-default">
                <div class="panel-heading">Mgazines</div>
                <div class="panel-body">
                  @foreach($mag as $mag)
                  <a href="{{url('/viewPDF',$mag->id)}}" class="btn btn-warning btn-lg">
                    <span class="glyphicon glyphicon-star" aria-hidden="true"></span>{{$mag->month}}
                  </a>
                  @endforeach
                </div>
            </div>

        </div>
    </div>
</div>
@endsection
