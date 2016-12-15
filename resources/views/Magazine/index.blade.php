@extends('layouts.app')
@section('content')
<div class="container">
    <div class="row">
        <div class="col-md-8 col-md-offset-2">
            <div class="panel panel-default">
                <div class="panel-heading">Dashboard</div>
                <div class="panel-body">
                    @if(Auth::User()->role>0)
                  <form enctype="multipart/form-data" method="POST" action="uploadMag">
                    <label>Month</label>
                    <input type="text" name="month">

                    <br>
                    <label>Version:</label>
                    <input type="text" name="version">
                    <input type="file" name="files" id="file">
                    <input type="hidden" name="_token" value="{{ csrf_token() }}">
                    <input type="submit" class="btn btn-primary" value="Upload">
                  </form>
                  <br>
                    @endif


                </div>
            </div>
        </div>
    </div>
</div>
@endsection
