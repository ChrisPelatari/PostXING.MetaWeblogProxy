require 'versionomy'
require 'os'

DIR = File.dirname(__FILE__)

hotfix = ENV["hotfix"] || "1"

task :default => [:build]

task :build do 
  sh "dotnet build"
end

task :test do
  sh "dotnet test"
end

desc "Run a version bump on assemblyinfo.cs"
task :version do 
  puts "versioning PostXING.MetaWeblogProxy..."
  file_path = "#{DIR}/PostXING.MetaWeblogProxy.csproj"
  pattern = /\d+\.\d+\.\d+\.\d+/

  hotfix = ENV["hotfix"] || "1"

  t = Time.now
  major = (t.year - 1980) / 10
  #major = major.floor + 1
  d = t.strftime "%d"
  y = t.year - (t.year - (t.year % 10))  #first year of the decade
  f = File.read file_path
  
  match = f.match pattern
  version = match != nil ? Versionomy.parse(match[0]) : Versionomy.parse("1.#{y}.0.0")
  day = version.tiny  
  puts "day is #{day}"

  if day == "#{t.month}#{d}".to_i then
    hotfix = version.tiny2
    puts "incrementing hotfix...original version is #{hotfix}"
    hotfix += 1
  end
  
  version = "#{major}.#{y}.#{t.month}#{d}.#{hotfix}"
  assembly_info = f.sub(pattern, "#{version}")

  File.write(file_path, assembly_info)

  puts "Done. Version is: #{version}"
end

desc "opens visual studio"
task :vs do
  if OS.doze?
    sh "start *.sln"
  else
    sh "open *.sln"
  end
end